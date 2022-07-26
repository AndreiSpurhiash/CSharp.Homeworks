using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using hw._111;

namespace hw._11
{
    public class Motorcycle : BaseEntity
    {

        public override Guid  Id { get; set; }

        public string Name { get; set; }

        private string Model { get; }
        private int Year { get; }
        
        private int Odometer { get; }
    }
}
