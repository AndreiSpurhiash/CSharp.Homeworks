using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pilot_project
{
    internal class Sushi
    {
        public int _ID { get; set; }
        private string _Name { get; set; }

        private double _Coast { get; set; }

        private string _Description { get; set; }

        public Sushi(int id,string name, double coast, string description)
        {
            _ID = id;
            _Name = name;
            _Coast = coast;
            _Description = description;
        }
    }
}
