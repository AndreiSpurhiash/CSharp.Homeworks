using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw12.task1
{
    internal class EngineerRepositoryStaticCollection : IEngineer
    {
        private static List<Engineer> _collection = new List<Engineer>();

        public void CreateEngineer(Engineer engineer)
        {
            _collection.Add(engineer);
        }

        public void DeleteEngineer(Guid id)
        {
            foreach (var item in _collection)
            {
                if (item.id == id)
                    _collection.Remove(item);
            }

        }

        public List<Engineer> GetAll()
        {
            return _collection;
        }

        public Engineer Update(Engineer engineer)
        {
            return engineer;
        }
    }
}
