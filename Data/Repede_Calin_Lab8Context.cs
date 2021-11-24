using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Repede_Calin_Lab8.Models;

namespace Repede_Calin_Lab8.Data
{
    public class Repede_Calin_Lab8Context : DbContext
    {
        public Repede_Calin_Lab8Context (DbContextOptions<Repede_Calin_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Repede_Calin_Lab8.Models.Book> Book { get; set; }

        public DbSet<Repede_Calin_Lab8.Models.Publisher> Publisher { get; set; }

        public DbSet<Repede_Calin_Lab8.Models.Category> Category { get; set; }
    }
}
