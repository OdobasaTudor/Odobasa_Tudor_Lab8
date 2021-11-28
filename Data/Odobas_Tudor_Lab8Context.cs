using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Odobas_Tudor_Lab8.Models;

namespace Odobas_Tudor_Lab8.Data
{
    public class Odobas_Tudor_Lab8Context : DbContext
    {
        public Odobas_Tudor_Lab8Context (DbContextOptions<Odobas_Tudor_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Odobas_Tudor_Lab8.Models.Book> Book { get; set; }

        public DbSet<Odobas_Tudor_Lab8.Models.Publisher> Publisher { get; set; }
    }
}
