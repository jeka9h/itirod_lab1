using ClosedXML.Excel;
using lab1.Models;

namespace lab1.Service
{
    public class ExcelTools
    {
        public static void Write(Group group,string path)
        {
            var workbook = new XLWorkbook();
            var worksheet = workbook.Worksheets.Add("Лист1");
            worksheet.Cell("A" + 1).Value = "Фамилия";
            worksheet.Cell("B" + 1).Value = "Имя";
            worksheet.Cell("C" + 1).Value = "Отчество";
            worksheet.Cell("D" + 1).Value = "Средняя оценка";
            int i = 0;
            for(i=0; i<group.Students.Count; i++)
            {
                worksheet.Cell("A" + (i+2)).Value = group.Students[i].Surname;
                worksheet.Cell("B" + (i + 2)).Value = group.Students[i].Name;
                worksheet.Cell("C" + (i + 2)).Value = group.Students[i].Patronymic;
                worksheet.Cell("D" + (i + 2)).Value = group.Students[i].Avg;
            }
            worksheet.Cell("A" + (i+2)).Value = "Физика";
            worksheet.Cell("A" + (i + 3)).Value = "Математика";
            worksheet.Cell("A" + (i + 4)).Value = "Черчение";
            worksheet.Cell("A" + (i + 5)).Value = "Химия";
            worksheet.Cell("A" + (i + 6)).Value = "Среднее по группе";
            worksheet.Cell("B" + (i + 2)).Value = group.AvgPhysics;
            worksheet.Cell("B" + (i + 3)).Value = group.AvgMaths;
            worksheet.Cell("B" + (i + 4)).Value = group.AvgDrawing;
            worksheet.Cell("B" + (i + 5)).Value = group.AvgChemistry;
            worksheet.Cell("B" + (i + 6)).Value = group.AvgGroup;
            worksheet.Columns().AdjustToContents();
            workbook.SaveAs("Base.xlsx");
        }
    }
}
