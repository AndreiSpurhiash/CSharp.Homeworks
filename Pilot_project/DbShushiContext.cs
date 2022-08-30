using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Pilot_project
{
    internal class DbShushiContext : DbContext
    {

        public DbShushiContext() : base("DefaultConnection")
        {
        }
        public DbSet<Sushi> Sushis { get; set; }

    }
}
