using Final_project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Final_project.BL
{
        public interface IServiceSushiCrud<T> 
        where T : Sushi
    {

        IEnumerable<T> GetSushiList();
        Task <T> GetSushi(int number);
        Task<T> Create(T sushi);
        Task<T> Update(T sushi1);
        Task<T> Delete(T number);
        Task<T> Save();
    }
}
