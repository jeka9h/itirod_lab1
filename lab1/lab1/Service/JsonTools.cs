using lab1.Models;
using Newtonsoft.Json;
using System.IO;

namespace lab1.Service
{
    public class JsonTools
    {
        public static void Write(Group group,string path)
        {
            string data = JsonConvert.SerializeObject(group);
            WriteToFile(data, path);
        }
        private static void WriteToFile(string data,string path)
        {
            using (StreamWriter sw = new StreamWriter(path, false, System.Text.Encoding.Default))
            {
                sw.WriteLine(data);
            }
        }
    }
}
