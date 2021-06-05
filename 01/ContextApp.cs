using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace _01
{
    public class ContextApp : DbContext
    {
        public DbSet<Phone> Phones { get; set; }
        public ContextApp()
        {
            Database.EnsureDeleted();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\;Database=TestDB_001;Trusted_Connection=True;");
        }
    }
}
