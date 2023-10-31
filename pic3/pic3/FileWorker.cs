using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pic3
{
    class FileWorker
    {
        static public void saveData(string text, string filepath)
        {
            StreamWriter writer = new StreamWriter(filepath, false);
            writer.WriteLine(text);
            writer.Close();

        }
        static public string getData(string filepath)
        {
            StreamReader reader = new StreamReader(filepath);
            string text = reader.ReadToEnd();
            reader.Close();
            return text;
        }
    }
}
