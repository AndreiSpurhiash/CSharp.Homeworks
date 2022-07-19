using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW09.Booking.Com.Models
{
    internal class User
    {
        protected int id;
        protected string _Name { get; set; } = "User";
        protected int _Age { get; set; } = 18;
        protected int _numerofguest { get; set; } = 1;

        public User(string Name, int Age, int numerofguest)
        {
            _Name = Name;
            _Age = Age;
            _numerofguest = numerofguest;

        }
        public void Hello()
        {
            Console.WriteLine($"Hello i am {_Name}. I am {_Age} years old. Numer guests = {_numerofguest}");
        }
    }
}