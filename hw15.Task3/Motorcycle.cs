using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw15.Task3
{
    internal class Motorcycle
    {
        public string Name { get; set; }
        public string Model { get; set; }

        public DateTime CreatedAt { get; set; }

        private int _vinNomber = 111;

        int _odometer;

        public int Odometer { get => _odometer; set => _odometer = value; }

        public Motorcycle()
        {

        }

        public Motorcycle(string name)
        {
            Name = name;
        }

        public Motorcycle( DateTime createdAt, string name )
        {
            CreatedAt = createdAt;
            Name = name;

        }

        public int GetVinNumber()
        {
            return _vinNomber; 
        }

        public override string ToString()
        {
            return $"Motorcycle : {Name}, Model : {Model}, Odometer : {Odometer}, " +
                $"VinNumber {GetVinNumber()}, Created {CreatedAt}";
        }

    }
}
