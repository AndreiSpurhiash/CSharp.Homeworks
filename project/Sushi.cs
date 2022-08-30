using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project
{
    internal class Sushi
    {
        private Guid _Id { get; set; }
        private int _Number { get; set; }
        private string _Name { get; set; }

        private double _Coast { get; set; }

        private string _Description { get; set; }

        public Sushi(int number, string name, double coast, string description)
        {
            _Id = Guid.NewGuid();
            _Number = number;
            _Name = name;
            _Coast = coast;
            _Description = description;
        }
    }
}
