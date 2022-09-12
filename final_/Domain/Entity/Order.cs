using Final_project.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_project.Domain.Entity
{
    public class Order : IEntity
    {
        public Guid Guid { get; set; }
        public DateTime _DateOrder { get; set; }
        public decimal _Price { get; set; }
        public Client Client { get; set; }
        public Basket Basket { get; set; }
        public Guid GuidBasket { get; set; }

        public Guid ClientGuid { get; set; }

        public ICollection<Sushi> Sushi { get; set; } = new List<Sushi>();


        public Order(decimal Price)
        {
            Guid = Guid.NewGuid();
            _DateOrder = DateTime.Now;
            _Price = Price;
        }
    }
}
