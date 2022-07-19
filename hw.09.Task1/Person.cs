using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Person
    {
        protected string name;
        protected int age;

        public void Name( string _name)
        {
            name = _name;
        }
        
       public void SetAge( int n)
        {
            age = n;
        }

        public  void Greet()
        {
            Console.WriteLine("Person " + name + " says hello.");
        }

    }
}
