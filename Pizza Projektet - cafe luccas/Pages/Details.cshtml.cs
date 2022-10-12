using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Pizza_Projektet___cafe_luccas.Data;
using Pizza_Projektet___cafe_luccas.Models;

namespace Pages
{
    public class DetailsModel : PageModel
    {
        private readonly Pizza_Projektet___cafe_luccas.Data.Pizza_Projektet___cafe_luccasContext _context;

        public DetailsModel(Pizza_Projektet___cafe_luccas.Data.Pizza_Projektet___cafe_luccasContext context)
        {
            _context = context;
        }

        public PizzaMenu PizzaMenu { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            PizzaMenu = await _context.PizzaMenu.FirstOrDefaultAsync(m => m.PizzaID == id);

            if (PizzaMenu == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
