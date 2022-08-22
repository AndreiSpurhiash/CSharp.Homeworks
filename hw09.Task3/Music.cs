using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Item_space;

namespace Music_space
{
    internal class Music : Item
    {
        protected string _singer;
        protected int _lenght;


        public Music(string name, string code, string category, string size, string director, string mainActor, string mainActress, string singer, int lenght) : base(name, code, category, size)
        {
            _singer = singer;
            _lenght = lenght;
        }
        public void Play()
        {

        }
        public void RetrieveInformation()
        {

        }
    }
}
}


