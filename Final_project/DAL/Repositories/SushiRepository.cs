﻿using Final_project.DAL.Interfaces;
using Final_project.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_project.DAL.Repositories
{
    internal class SushiRepository : ISushiRepository
    {
        readonly SushinContext db;
        public SushiRepository()
        {
            db = new SushinContext();
        }

        public void Create(Sushi sushi)
        {
            db.Sushis.Add(sushi);
        }

        public void Delete(Sushi sushi)
        {
            db.Sushis.Remove(sushi);
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

        public Sushi GetID(Guid id)
        {
            return db.Sushis.Find(id);
        }

        public async Task<IEnumerable<Sushi>> GetListAsync()
        {
            return await db.Sushis.ToListAsync().ConfigureAwait(false);
        }

        public Sushi GetNumer(int number)
        {
            return db.Sushis.Find(number);
        }

        public void Save()
        {
            db.SaveChanges();
        }

        public void Update(Sushi sushi)
        {
            db.Entry(sushi).State = EntityState.Modified;
        }
    }
}
