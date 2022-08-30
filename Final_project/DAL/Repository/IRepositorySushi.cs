using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Final_project.Models;

namespace Final_project.Repository
{
    interface IRepositorySushi<T> : IDisposable
        where T : Sushi
    {
        IEnumerable<T> GetSushiList();
        Sushi GetSushi(int number);
        void Create(T sushi);
        void Update(T sushi1);
        void Delete(T number);
        void Save();
    }
}
