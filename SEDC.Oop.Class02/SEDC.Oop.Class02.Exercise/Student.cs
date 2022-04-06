using SEDC.Oop.Class02.Exercise.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Oop.Class02.Exercise
{
    public class Student : User, IStudent
    {
        public int Grades { get; set; }

        override public void PrintUser()
        {
            Console.WriteLine($"The student named : {Name} has {Grades} grade.");
        }
    }
}
