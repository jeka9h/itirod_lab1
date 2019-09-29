using CsvHelper.Configuration.Attributes;
using System.Runtime.Serialization;

namespace lab1.Models
{
    [DataContract]
    public class Student
    {
        [DataMember]
        [Name("Фамилия")]
        public string Surname { get; set; }
        [DataMember]
        [Name("Имя")]
        public string Name { get; set; }
        [DataMember]
        [Name("Отчество")]
        public string Patronymic { get; set; }
        [Name("Математика")]
        public int Maths { get; set; }
        [Name("Физика")]
        public int Physics { get; set; }
        [Name("Химия")]
        public int Chemistry { get; set; }
        [Name("Черчение")]
        public int Drawing { get; set; }
        [DataMember]
        public double Avg { get; set; }
        public void CalculateAvg()
        {
            Avg = (Maths+Physics+Chemistry+Drawing)/4.0;
        }
    }
    
}
