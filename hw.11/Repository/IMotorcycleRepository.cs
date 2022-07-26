using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw._11.Repository
{
    internal interface IMotorcycleRepository
    {
        void CreateMotorcycle (Motorcycle motorcycle);

        List<Motorcycle> GetAll ();
        
        void DeleteMotorcycle (Guid id);

        Motorcycle Update (Motorcycle motorcycle);  

    }
}
