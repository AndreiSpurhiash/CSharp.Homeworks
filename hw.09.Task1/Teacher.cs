using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1;

namespace Teacher_n
{
    internal class Teacher: Person
    {
        public void Explain()
        {
            Console.WriteLine("Explanation begins");
        }
        public void Hello()
        {
            Console.WriteLine($"Hello! My name is {name}.My age is {age} years old");
        }
    }
}
