using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppStudentManagement.Model
{
    public class History : SubjectModel
    {
        public History()
        {
            if (this.BonusPoint != null)
            {
                double sumMidterm = 0;
                for (var i = 0; i < this.Midterm.Count; i++)
                {
                    sumMidterm += this.Midterm[i];
                }

                this.FinalResult = (double)((sumMidterm / this.Midterm.Count + this.BonusPoint + FinalExam * 2) / 4);
            }
        }

        public double? BonusPoint { get; set; }

    }
}
