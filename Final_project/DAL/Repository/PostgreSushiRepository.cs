using Final_project.DAL;
using Final_project.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_project.Repository
{
    internal class PostgreSushiRepository : IRepositorySushi<Sushi>
    {
        private SushinContext db;

        public PostgreSushiRepository()
        {
            db = new SushinContext();
        }

        public IEnumerable<Sushi> GetSushiList()
        {
            return db.Sushis;
        }
        public void Create(Sushi sushi)
        {
            db.Sushis.Add(sushi);
        }

        public void Delete(Sushi number)
        {
            db.Sushis.Remove(number);
        }


        private bool disposed = false;

        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    db.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
       

        public Sushi GetSushi(int number)
        {
            return db.Sushis.Find(number);
        }

        public void Save()
        {
            db.SaveChanges();
        }

        public void Update(Sushi sushi1)
        {
            db.Entry(sushi1).State = EntityState.Modified;
        }
    }
}
