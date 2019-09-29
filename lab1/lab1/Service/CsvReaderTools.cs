using CsvHelper;
using lab1.Models;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace lab1.Service
{
    public class CsvReaderTools
    {
        public static List<Student> Read(string path)
        {
            using (StreamReader reader =new StreamReader(path))
            {
                using (CsvReader csvReader = new CsvReader(reader))
                {
                    csvReader.Configuration.Delimiter = ";";
                    csvReader.Configuration.HeaderValidated = null;
                    csvReader.Configuration.MissingFieldFound = null;
                    var data= csvReader.GetRecords<Student>().ToList();
                    foreach (Student student in data)
                        student.CalculateAvg();
                    return data;
                }
            }
        }
    }
}
