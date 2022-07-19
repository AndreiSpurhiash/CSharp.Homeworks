using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1;

namespace Student_name
{
    internal class Student : Person
    {
        public void GoToClasses()
        {
            Console.WriteLine("I’m going to class");
        }

        public void ShowAge()
        {
            Console.WriteLine($"My age is { age } years old");
        }
        public void Hello()
        {
            Console.WriteLine($"Hello! My name is {name}.My age is {age} years old");
        }
            
    }
}