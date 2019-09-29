using System.Collections.Generic;

namespace lab1.Models
{
    public class Group
    {
        public List<Student> Students { get; set; }
        public double AvgMaths { get; set; }
        public double AvgPhysics { get; set; }
        public double AvgChemistry { get; set; }
        public double AvgDrawing { get; set; }
        public double AvgGroup { get; set; }
        public void CalcAvg()
        {
            double avg = 0;
            foreach(Student student in Students)
            {
                avg += student.Maths;
            }
            AvgMaths=avg / Students.Count;
            avg = 0;
            foreach (Student student in Students)
            {
                avg += student.Physics;
            }
            AvgPhysics = avg / Students.Count;
            avg = 0;
            foreach (Student student in Students)
            {
                avg += student.Chemistry;
            }
            AvgChemistry = avg / Students.Count;
            avg = 0;
            foreach (Student student in Students)
            {
                avg += student.Drawing;
            }
            AvgDrawing = avg / Students.Count;
            avg = 0;
            AvgGroup = (AvgMaths+ AvgPhysics+ AvgChemistry+ AvgDrawing)/4;
        }
    }
}
