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

        public DbSet<PizzaMenu> PizzaMenu { get; set; }

        public DbSet<Customers> Customers { get; set; }

        public DbSet<Pizza_Projektet___cafe_luccas.Models.CustomerOrders> CustomerOrders { get; set; }

        
    }
}
