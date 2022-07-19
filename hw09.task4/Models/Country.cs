using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW09.Booking.Com.Models
{
    internal class Country
    {
        protected string _country { get; set; }
        protected string _city { get; set; }

        public Country(string country, string city)
        {
            _country = country;
            _city = city;
        }
        public void YouCountry()
        {
            Console.WriteLine($"Your {_country}, city {_city}");
        }
    }
  
}
