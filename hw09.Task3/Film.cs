using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Item_space;

namespace Film_space
{
    internal class Film : Item
    { 
        protected string _director;
        protected string _mainActor;
        protected string _mainActress;

        public Film(string name, string code, string category, string size, string director, string mainActor, string mainActress) : base(name, code, category, size)
        {
            _director = director;
            _mainActor = mainActor;
            _mainActress = mainActress;
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