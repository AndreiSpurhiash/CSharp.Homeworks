using Final_project.DAL.Interfaces;
using Final_project.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_project.DAL.Repositories
{
    internal class OrderRepository : IOrderRepository
    {
        readonly SushinContext db;
        public OrderRepository()
        {
            db = new SushinContext();
        }
        public void Create(Order order)
        {
            db.Orders.Add(order);
        }

        public void Delete(Order order)
        {
            db.Orders.Remove(order);
        }

        private bool disposed = false;

        public virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    db.Dispose();
                }
            }
            disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public Order GetID(Guid id)
        {
            return db.Orders.Find(id);
        }

        public async Task<IEnumerable<Order>> GetListAsync()
        {
            return await db.Orders.ToListAsync().ConfigureAwait(false);
        }

        public void Save()
        {
            db.SaveChanges();
        }

        public void Update(Order order)
        {
            db.Entry(order).State = EntityState.Modified;
        }
    }
}
