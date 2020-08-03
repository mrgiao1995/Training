using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppStudentManagement.Model
{
    public class StudentModel : BaseModel
    {
        public string FullName { get; set; }
        public string Address { get; set; }
        public DateTime DateOfBirth { get; set; }

        public Math Math { get; set; }
        public History History { get; set; }

    }
}
