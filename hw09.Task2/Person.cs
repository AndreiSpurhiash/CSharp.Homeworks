using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using hw08.House_space;

namespace hw09.Task2_
{
    internal class Person
    {
        public string name { get; set; } = "Tom";
     
        protected House house;

        public Person()
        {
            name = "Tom";
            house = new House(150);
        }
        public Person(string name, House house)
        {
            this.name = name;
            this.house = house;
        }
    }
}
