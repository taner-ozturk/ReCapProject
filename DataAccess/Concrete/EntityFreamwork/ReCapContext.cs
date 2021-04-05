using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFreamwork
{
    public class ReCapContext : DbContext
    {
        //Context: Db tabloları ile proje classlarını bağlar
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\msssqllocaldb;Database=Recap;Trusted_connection=true");
        }
        public DbSet<Brand> brands { get; set; }
        public DbSet<Car> cars { get; set; }
        public DbSet<Color> colors { get; set; }
    }
}
