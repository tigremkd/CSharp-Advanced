using SEDC.Oop.Class02.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Oop.Class02.Entities
{
    public class Pen : IThingsThatCanWriteANote
    {
        public void WriteNote()
        {
            Console.WriteLine("This is written with a pen.");
        }
    }
}
