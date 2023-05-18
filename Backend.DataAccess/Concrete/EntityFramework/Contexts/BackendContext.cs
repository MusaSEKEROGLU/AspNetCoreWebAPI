using Backend.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Backend.DataAccess.Concrete.EntityFramework.Contexts
{
    public class BackendContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-THSSRI7\\SQLEXPRESS;Initial Catalog=Dbo_Northwind;Integrated Security=True;");
        }
        public DbSet<Product> Products { get; set; }
    }
    
}
