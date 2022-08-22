using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw12.task1
{
    internal interface IEngineer
    {
         void CreateEngineer(Engineer engineer);

        List<Engineer> GetAll();

        void DeleteEngineer(Guid id);

        Engineer Update(Engineer engineer);
    }
}
