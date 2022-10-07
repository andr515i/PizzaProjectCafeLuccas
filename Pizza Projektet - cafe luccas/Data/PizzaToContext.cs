using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PizzaTo.Models;

namespace PizzaTo.Data
{
    public class PizzaToContext : DbContext
    {
        public PizzaToContext (DbContextOptions<PizzaToContext> options)
            : base(options)
        {
        }

        public DbSet<PizzaTo.Models.Pizza> Pizza { get; set; }
    }
}
