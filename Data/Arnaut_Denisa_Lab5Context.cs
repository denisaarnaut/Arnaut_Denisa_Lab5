using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Arnaut_Denisa_Lab5.Models;

namespace Arnaut_Denisa_Lab5.Data
{
    public class Arnaut_Denisa_Lab5Context : DbContext
    {
        public Arnaut_Denisa_Lab5Context (DbContextOptions<Arnaut_Denisa_Lab5Context> options)
            : base(options)
        {
        }

        public DbSet<Arnaut_Denisa_Lab5.Models.Book> Book { get; set; }

        public DbSet<Arnaut_Denisa_Lab5.Models.Publisher> Publisher { get; set; }

        public DbSet<Arnaut_Denisa_Lab5.Models.Category> Category { get; set; }
    }
}
