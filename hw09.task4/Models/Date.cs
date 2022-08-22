using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW09.Booking.Com.Models
{
    internal class Date
    {
        protected double _datestart { get; }
        protected double _datefinish { get; set; }

        public Date(double datestart, double datefinish)
        {
            _datestart = datestart;
            _datefinish = datefinish;
        }
        public void DateRent()
        {
            Console.WriteLine($"Your start date or rent {_datestart}, finish {_datefinish}");
        }
    }
}
