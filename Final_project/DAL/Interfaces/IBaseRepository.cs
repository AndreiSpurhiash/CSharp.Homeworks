using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Final_project.Domain.Entity;

namespace Final_project.DAL.Interfaces
{
    interface IBaseRepository<T> : IDisposable
    {
        Task<IEnumerable<T>> GetListAsync();
        T GetID(int id);
        void Create(T entity);
        void Update(T entity);
        void Delete(T entity);
        void Save();
    }
}
