using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_OOP_1
{
    internal class Student
    {
        //----------------------------------- Video 05 -----------------------------------
        public int Id { get; set; }
        public string? Name { get; set; }
        public Gender Gender { get; set; }
        public Grades Grade { get; set; }

        public Branch branch { get; set; }

    }
}
