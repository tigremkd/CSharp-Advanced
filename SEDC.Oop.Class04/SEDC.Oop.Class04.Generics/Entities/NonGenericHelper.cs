using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Oop.Class04.Generics.Entities
{
    public class NonGenericHelper
    {
        public void GoTroughStringList(List<string> strings)
        {
            foreach (string s in strings)
            {
                Console.WriteLine(s);
            }
        }

        public void GetInfoForList(List<string> strings)
        {
            Console.WriteLine($"The list has { strings.Count } and the elements are of type { strings[0].GetType() }");
        }
    }
}
