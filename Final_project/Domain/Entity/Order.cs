using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_project.Domain.Entity
{
    public class Order
    {
        public Guid _IdOrder { get; set; }
        public DateTime _DateOrder { get; set; } = DateTime.Now;
        public string _NameClient { get; set; }
        public string _PhoneClient { get; set; }
        public string _AdresOrder { get; set; }
        //public string[] _Orders { get; set; }
        public decimal _Price { get; set; }
    }
}
