using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_project.Domain.Entity
{
    public class Client
    {
        public string _NameClient { get; set; }
        public string _AdresClient { get; set; }
        public string _NumberPhone { get; set; }
        public Guid _IdClient { get; set; }
        public string _MailClient { get; set; }

        public Client(string NameClient, string AdresClient, string NumberPhone, string MailClient)
        {
            _IdClient = Guid.NewGuid();
            _NameClient = NameClient;
            _AdresClient = AdresClient; 
            _NumberPhone = NumberPhone;
            _MailClient = MailClient;

        }

    }
}
