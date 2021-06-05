using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace _02
{
    class ContextApp : DbContext
    {

        public DbSet<Phone> Phones { get; set; }

        public ContextApp()
        {
            Database.EnsureDeleted();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\;Database=TestDB_002;Trusted_Connection=True;");
        }
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Phone>().Ignore(b => b.CurrentRate);
        //}

    }
}
