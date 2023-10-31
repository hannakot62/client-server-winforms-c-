using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;
using System.Text.Unicode;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pic3Client
{
    public partial class Form1 : Form
    {
        private TcpClient client;
        private NetworkStream stream;
        private StreamReader reader;
        private StreamWriter writer;
        JsonSerializerOptions options = new JsonSerializerOptions
        {
            Encoder = System.Text.Encodings.Web.JavaScriptEncoder.Create(UnicodeRanges.All)

        };

        public Form1()
        {
            InitializeComponent();
            InitializeClient();
            makeAllDisabled();
        }

        private void InitializeClient()
        {
            try
            {
                client = new TcpClient("127.0.0.1", 5555); 
                stream = client.GetStream();
                reader = new StreamReader(stream, Encoding.UTF8);
                writer = new StreamWriter(stream, Encoding.UTF8);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка подключения к серверу: " + ex.Message);
            }
        }

        private void SendCommand(string command, string body)
        {
            try
            {
                string request = command + "|" + body;
                writer.WriteLine(request);
                writer.Flush();
                Log($"Отправлено: {command}");

                string response = reader.ReadLine();
                Log($"Ответ от сервера: {response}");

                ProcessResponse(command, response);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка отправки команды: " + ex.Message);
            }
        }

        private void ProcessResponse(string command, string response)
        {
            if (response.Length != 0)
            {
                switch (command)
                {
                    case "showAll":
                        {
  
                            List<Vegetable> vegetables = JsonSerializer.Deserialize<List<Vegetable>>(response, options);
                            if (vegetables.Count == 0)
                            {
                                ShowResponse("No vegetables are available :(");
                            }
                            else
                            {
                                ShowResponse(" _____________________________________________");
                                ShowResponse("|№п/п|     Название     |Количество|   Цвет   |");
                                ShowResponse("|____|__________________|__________|__________|");

                                for (int i = 0; i < vegetables.Count; i++)
                                {
                                    ShowResponse($"|{(i + 1).ToString().PadRight(4, ' ')}|" +
                                        $"{vegetables[i].name.PadRight(18, ' ')}|" +
                                        $"{vegetables[i].quantity.ToString().PadRight(10, ' ')}|" +
                                        $"{vegetables[i].color.PadRight(10, ' ')}|");

                                    ShowResponse("|____|__________________|__________|__________|");
                                }
                            }
                            break;
                        }
                    case "add":
                        {
                            if (response.Length != 0)
                            {
                                ShowResponse(response);
                            }
                            break;
                        }
                    case "delete":
                        {
                            if (response.Length != 0)
                            {
                                ShowResponse(response);
                            }
                            break;
                        }
                    case "update":
                        {
                            if (response.Length != 0)
                            {
                                ShowResponse(response);
                            }
                            break;
                        }
                    case "search":
                        {

                            List<Vegetable> vegetables = JsonSerializer.Deserialize<List<Vegetable>>(response, options);
                            if (vegetables.Count == 0)
                            {
                                ShowResponse("No vegetables were found :(");
                            }
                            else
                            {
                                ShowResponse(" _____________________________________________");
                                ShowResponse("|№п/п|     Название     |Количество|   Цвет   |");
                                ShowResponse("|____|__________________|__________|__________|");

                                for (int i = 0; i < vegetables.Count; i++)
                                {
                                    ShowResponse($"|{(i + 1).ToString().PadRight(4, ' ')}|" +
                                        $"{vegetables[i].name.PadRight(18, ' ')}|" +
                                        $"{vegetables[i].quantity.ToString().PadRight(10, ' ')}|" +
                                        $"{vegetables[i].color.PadRight(10, ' ')}|");

                                    ShowResponse("|____|__________________|__________|__________|");
                                }
                            }
                            break;
                        }
                }

            }
        }

        private void Log(string message)
        {
            statusOutput.Items.Add(message + Environment.NewLine);
        }
        private void ShowResponse(string response)
        {
            output.Items.Add(response);
        }


        private void doBtn_Click(object sender, EventArgs e)
        {
            if (showAll.Checked)
            {
                string command = "showAll";
                SendCommand(command,"");
            }
            if (add.Checked)
            {
                string command = "add";
                string json = JsonSerializer.Serialize(new { name = name.Text, color = color.Text, quantity = int.Parse(quantity.Text) }, options);
                SendCommand(command, json);
            }
            if (update.Checked)
            {
                string command = "update";
                int q = -1;
                if (quantity.Text.Length != 0) { q = int.Parse(quantity.Text); }
                string json = JsonSerializer.Serialize(new { name = name.Text, color = color.Text, quantity = q, number=int.Parse(number.Text) });
                SendCommand(command, json);
            }
            if (delete.Checked)
            {
                string command = "delete";
                string json = JsonSerializer.Serialize(new { number = int.Parse(number.Text )});
                SendCommand(command, json);
            }
            if (search.Checked) {
                string command = "search";
                string json = JsonSerializer.Serialize(new { name = name.Text });
                SendCommand(command, json);
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            clearParameters();
            makeAllDisabled();
            number.Enabled = true;
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            clearParameters();
            makeAllDisabled();
            name.Enabled = true;

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void add_CheckedChanged(object sender, EventArgs e)
        {
            clearParameters();
            makeAllEnabled();
            number.Enabled = false;
        }

        private void clearParameters()
        {
            name.Text = "";
            color.Text = "";
            quantity.Text = "";
            number.Text = "";
        }
        private void makeAllEnabled()
        {
            name.Enabled = true;
            color.Enabled = true;
            quantity.Enabled = true;
            number.Enabled = true;
        }
        private void makeAllDisabled()
        {
            name.Enabled = false;
            color.Enabled = false;
            quantity.Enabled = false;
            number.Enabled = false;
        }

        private void update_CheckedChanged(object sender, EventArgs e)
        {
            clearParameters();
            makeAllEnabled();
        }

        private void showAll_CheckedChanged(object sender, EventArgs e)
        {
            clearParameters();
            makeAllDisabled();
        }
    }
}

