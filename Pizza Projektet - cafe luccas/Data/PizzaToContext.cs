using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Pizza_Projektet___cafe_luccas.Models;

namespace Pizza_Projektet___cafe_luccas.Data
{
    public class Pizza_Projektet___cafe_luccasContext : DbContext
    {
        public Pizza_Projektet___cafe_luccasContext (DbContextOptions<Pizza_Projektet___cafe_luccasContext> options)
            : base(options)
        {
        }
        // this is the tables we "import" into the project. we cant access tables if we dont make an instance of something that is 99% the same... microsoft logic :D
        public DbSet<PizzaMenu> PizzaMenu { get; set; }

        public DbSet<Customers> Customers { get; set; }

        public DbSet<CustomerOrders> CustomerOrders { get; set; }

        
    }
}
