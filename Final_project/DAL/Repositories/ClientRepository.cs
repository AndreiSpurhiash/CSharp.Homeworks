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
    internal class ClientRepository : IClientRepository
    {
        readonly SushinContext db;
        public ClientRepository()
        {
            db = new SushinContext();
        }
        public void Create(Client client)
        {
            db.Clients.Add(client);
        }

        public void Delete(Client client)
        {
            db.Clients.Remove(client);
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

        public Client GetID(Guid id)
        {
            return db.Clients.Find(id);
        }

        public async Task<IEnumerable<Client>> GetListAsync()
        {
            return await db.Clients.ToListAsync().ConfigureAwait(false);
        }

        public void Save()
        {
            db.SaveChanges();
        }

        public void Update(Client client)
        {
            db.Entry(client).State = EntityState.Modified;
        }
    }
}
