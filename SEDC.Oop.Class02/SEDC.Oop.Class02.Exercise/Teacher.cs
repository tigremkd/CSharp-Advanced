using SEDC.Oop.Class02.Exercise.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Oop.Class02.Exercise
{
    public class Teacher : User, ITeacher
    {
        public string Subject { get; set; }

        public override void PrintUser()
        {
            Console.WriteLine($"This teacher {Name}, teaches {Subject}");
        }
    }
}
