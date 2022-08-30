using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pilot_project
{
    internal class Person
    {
        protected Guid _Id { get; set; }
        protected string _Name { get; set; }

        protected int _NumberPhone { get; set; }

        protected string _Adress { get; set; }

        protected string _Email { get; set; }

        public Person(string name)
        {
            _Name = name;
        }

        public string Name()
        { 
        return _Name;
        }
    }
}
