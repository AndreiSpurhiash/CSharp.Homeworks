using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Serilog.Core;
using Serilog.Core.Pipeline;
using Serilog.Events;
using Serilog;



namespace hw._11.Repository
{
    internal class MotorcycleRepositoryStaticCollection : IMotorcycleRepository
    {
        private static List<Motorcycle> _collection = new List<Motorcycle>();
        public void CreateMotorcycle(Motorcycle motorcycle)
        {
            _collection.Add(motorcycle);
        }

        public void DeleteMotorcycle(Guid id)
        {
            foreach (var item in _collection)
            {
                if (item.Id == id)
                    _collection.Remove(item);
            }
        }

        public List<Motorcycle> GetAll()
        {
            return _collection;
        }

        public  Motorcycle Update(Motorcycle motorcycle)
        {
            return motorcycle;
        }
    }
}
