using Entity_Framework_Core_Fundies.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Framework_Core_Fundies.Data
{
    public class PizzaDbContext :DbContext
    {
        public DbSet<Customer> Customers { get; set; } = null!;
        public DbSet<Order> Orders { get; set; } = null!;
        public DbSet<Product> Products { get; set; } = null!;
        public DbSet<OrderDetail> OrderDetails { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=host.docker.internal,1443;Initial Catalog=Pizza; Integrated Security=False;TrustServerCertificate=True; User ID=sa;Password=adminADMIN!1;
");
        }
    }
}
