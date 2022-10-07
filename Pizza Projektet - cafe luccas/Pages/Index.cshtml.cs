using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PizzaTo.Data;
using PizzaTo.Models;

namespace PizzaTo.Pages
{
    public class IndexModel : PageModel
    {
        private readonly PizzaTo.Data.PizzaToContext _context;

        public IndexModel(PizzaTo.Data.PizzaToContext context)
        {
            _context = context;
        }

        public IList<Pizza> Pizza { get;set; }

        public async Task OnGetAsync()
        {
            Pizza = await _context.Pizza.ToListAsync();
        }
    }
}
