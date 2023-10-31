using System;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.Unicode;
using System.Text.RegularExpressions;
using System.Linq;

namespace pic3
{
    public partial class Form1 : Form
    {
        private TcpListener listener;
        private TcpClient client;
        JsonSerializerOptions options = new JsonSerializerOptions
        {
            Encoder = System.Text.Encodings.Web.JavaScriptEncoder.Create(UnicodeRanges.All)

        };
        [Serializable]
        public class NumberObject
        {
            public int number { get; set; }
        }

        [Serializable]
        public class PartNameObject
        {
            public string name { get; set; }
        }
        [Serializable]
        public class UpdateObject
        {
            public int number { get; set; }
            public string name { get; set; }
            public int quantity { get; set; }
            public string color { get; set; }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void InitializeServer()
        {
            listener = new TcpListener(IPAddress.Any, 5555);
            listener.Start();
            Log("Сервер ожидает подключения клиента...");

            Task.Run(() => ProcessCommands()); // Запускаем обработку команд в отдельном потоке
        }

        private async void ProcessCommands()
        {
            try
            {
                while (true)
                {
                    client = await listener.AcceptTcpClientAsync();
                    Log("Клиент подключен.");

                    NetworkStream stream = client.GetStream();
                    StreamReader reader = new StreamReader(stream, Encoding.UTF8);
                    StreamWriter writer = new StreamWriter(stream, Encoding.UTF8);

                    while (true)
                    {
                        string command = await reader.ReadLineAsync();
                        if (command == null)
                        {
                            break; 
                        }
                        string[] fullRequest = command.Split("|");
                        string body = fullRequest[1];
                        command = fullRequest[0];

                        Log($"Получена команда от клиента: {command}");
                        string response = ProcessCommand(command, body);
                        await writer.WriteLineAsync(response);
                        await writer.FlushAsync();
                        Log($"Отправлен ответ клиенту: {response}");
                    }

                    Log("Клиент отключился.");
                    stream.Close();
                    client.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при обработке команды: " + ex.Message);
            }
        }

        private string ProcessCommand(string command, string body)
        {
            switch (command)
            {
                case "showAll":
                    {
                        List<Vegetable> allVegetables = readVegetables();
                        string response = JsonSerializer.Serialize(allVegetables, options);
                        return response;
                    }
                case "add":
                    {
                        List<Vegetable> allVegetables = readVegetables();
                        Vegetable vegetable = JsonSerializer.Deserialize<Vegetable>(body, options);
                        allVegetables.Add(vegetable);
                        writeVegetables(allVegetables);   
                        return "Новый овощ добавлен!!!";
                    }
                case "delete":
                    {
                        List<Vegetable> allVegetables = readVegetables();
                        int num = JsonSerializer.Deserialize<NumberObject>(body, options).number;
                        allVegetables.RemoveAt(num - 1);
                        writeVegetables(allVegetables);
                        return "Овощ удален";
                    }
                case "update":
                    {
                        List<Vegetable> allVegetables = readVegetables();
                        UpdateObject obj = JsonSerializer.Deserialize<UpdateObject>(body, options);
                        if (obj.name.Length != 0) allVegetables[obj.number - 1].name = obj.name;
                        if (obj.color.Length != 0) allVegetables[obj.number - 1].color = obj.color;
                        if (obj.quantity!=-1) allVegetables[obj.number - 1].quantity = obj.quantity;
                        writeVegetables(allVegetables);
                        return "Обновление добавлено";
                    }
                case "search":
                    {
                        List<Vegetable> allVegetables = readVegetables();
                        string query = JsonSerializer.Deserialize<PartNameObject>(body, options).name;
                        Regex regex = new Regex(@$"\w?{query}\w?");
                        List<Vegetable> found = allVegetables.Where(veg => regex.Matches(veg.name).Count > 0).ToList();
                        string response = JsonSerializer.Serialize(found, options);
                        return response;                    }
                default:
                    {
                        return "Неизвестная команда.";
                    }
            }

        }
    

        private void Log(string message)
        {
            Action action = () => richTextBox1.AppendText(message + Environment.NewLine);
            if (richTextBox1.InvokeRequired)
            {
                richTextBox1.Invoke(action);
            }
            else
            {
                action();
            }
        }

        private List<Vegetable> readVegetables()
        {
            List<Vegetable> allVegetables = new List<Vegetable>();
            string text = FileWorker.getData("demo.txt");
            if (text.Length != 0)
            {
                string[] rows = text.Split("\r\n");
                foreach (string row in rows)
                {
                    if (row != "\n" && row != "\r\n" && row != "")
                    {
                        string[] words = row.Split(" ");
                        allVegetables.Add(new Vegetable(words[0].ToString(), int.Parse(words[1].ToString()), words[2].ToString()));
                    }
                }
            }
            return allVegetables;
        }

        private void writeVegetables(List<Vegetable> allVegetables)
        {
            string text = "";
            foreach (Vegetable vegetable in allVegetables)
            {
                string row = vegetable.name + " " + vegetable.quantity.ToString() + " " + vegetable.color + "\r\n";
                text += row;
            }
            FileWorker.saveData(text, "demo.txt");
        }

        private void Button1_Click(object sender, EventArgs e) {
            InitializeServer();
        }
        private void richTextBox1_TextChanged(object sender, EventArgs e){ }
        private void Form1_Load(object sender, System.EventArgs e) { }

    }



    class PlainStringConverter : JsonConverter<string>
    {
        public override string Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType == JsonTokenType.String)
            {
                return reader.GetString();
            }
            else
            {
                return reader.GetString(); 
            }
        }

        public override void Write(Utf8JsonWriter writer, string value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(value);
        }
    }
}