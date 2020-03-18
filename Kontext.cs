using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2BLab3
{
    public class Kontext : DbContext
    {
        public DbSet<Zajecia> Zajecias { get; set; } 

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Data Source=T3rr0-Komputer;Initial Catalog=Northwind;Integrated Security=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            /*
            modelBuilder
                .Entity<Zajecia>()
                .Property(x => x.Nazwa)
                .HasMaxLength(255)
                .HasColumnName("NazwaFluent");   
                */

        }
    }
}
