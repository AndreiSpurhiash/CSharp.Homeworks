using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_project.Domain.Entity
{
    public class Basket
    {
        public Guid Id { get; set; }
        
        public Order Order { get; set; }
        public Guid GuidOrder { get; set; }

        public string NameSushi { get; set; }
        public ICollection<Sushi> Sushi { get; set; } = new List<Sushi>();
        public int Count { get; set; }
    }
}
