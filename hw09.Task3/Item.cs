using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Item_space
{
    internal class Item
    {
        protected string _name { get; set; }
        protected string _code { get; set; }
        protected string _category { get; set; }
        protected string _size { get; set; }

        public Item(string name, string code, string category, string size)
        {
            _name = name;
            _code = code;
            _category = category;
            _size = size;
        }
    }
}
