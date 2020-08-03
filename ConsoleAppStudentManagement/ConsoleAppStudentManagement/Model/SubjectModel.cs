using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppStudentManagement.Model
{
    public class SubjectModel : BaseModel
    {
        public SubjectModel()
        {
            double sumMidterm = 0;
            for (var i=0; i< this.Midterm.Count; i++)
            {
                sumMidterm += this.Midterm[i];
            }

            this.FinalResult = (sumMidterm / this.Midterm.Count + FinalExam * 2) / 3;
        }

        public string Name { get; set; }
        public List<double> Midterm { get; set; }
        public double FinalExam { get; set; }
        public double FinalResult;
    }
}
