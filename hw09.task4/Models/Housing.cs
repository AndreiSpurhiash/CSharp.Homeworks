using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW09.Booking.Com.Models
{
    internal class Housing
    {
        protected string _type { get; set; }
        protected int _room { get; set; }

        public Housing(string type, int room)
        {
            _type = type;
            _room = room;
        }
        public void Write()
        {
            Console.WriteLine($"Your type house {_type}, numer of rooms {_room}");
        }
    }
}
