using lab1.Models;
using lab1.Service;
using System;
using static System.Console;

namespace lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                if (args[0] == "-i" && args[2] == "-o" && args[4] == "-f")
                {
                    var data = CsvReaderTools.Read(args[1]);
                    Group group = new Group() { Students = data };
                    group.CalcAvg();
                    if (args[5] == "JSON")
                        JsonTools.Write(group, args[3] + ".json");
                    if (args[5] == "EXCEL")
                        ExcelTools.Write(group, args[3] + ".xlsm");
                }
                else
                    throw new Exception("bad params");

                
                //var data = CsvReaderTools.Read("data.csv");
                //Group group = new Group() { Students = data };
                //group.CalcAvg();
                //JsonTools.Write(group, "1.json");
                //ExcelTools.Write(group, "Base.xlsx");
            }
            catch (Exception ex)
            {
                WriteLine(ex.Message);
            }
            WriteLine("Работа закончена");
        }
    }
}
