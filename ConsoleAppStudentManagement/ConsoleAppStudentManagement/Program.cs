using ConsoleAppStudentManagement.Model;
using ConsoleAppStudentManagement.Module;
using System;
using System.Collections.Generic;

namespace ConsoleAppStudentManagement
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("It's Student Management Project!");
            Console.WriteLine("Firstly, please input some information");

            var student = new StudentModel();

            // InPut student  infomation

            StudentModule.InputStudentInfomation(student);

            // Khởi tạo giá trị các điểm

            var listMidterm = new List<double>();
            listMidterm.Add(10);
            listMidterm.Add(8);
            listMidterm.Add(9);

            student.Math = new Model.Math()
            {
                FinalExam = 8,
                Midterm = listMidterm
            };

            student.History = new History()
            {
                FinalExam = 8,
                Midterm = listMidterm,
                BonusPoint = 9
            };

            // In ra cái phiếu thông báo kết quả học tập
            // Phiếu kết quả sẽ trông như thế này

            //=====================================//
            // Ho va Ten: Nguyen Van A             //
            // Lop: 11A                            //
            // Dia chi: 123 Bo De, Long Bien, HN   //
            // Tong ket:                           //
            // Diem Toan: 8,5                      //
            // Diem Lich Su: 8                     //
            // Tong ket: 8.25                      //
            // Xep loai: Gioi                      //
            //=====================================//


        }
    }
}
