using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Pizza_Projektet___cafe_luccas.Data;
using Pizza_Projektet___cafe_luccas.Models;

namespace Pizza_Projektet___cafe_luccas.Pages
{
    public class DeleteModel : PageModel
    {
        private readonly Pizza_Projektet___cafe_luccas.Data.Pizza_Projektet___cafe_luccasContext _context;

        public DeleteModel(Pizza_Projektet___cafe_luccas.Data.Pizza_Projektet___cafe_luccasContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Pizza Pizza { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Pizza = await _context.Pizza.FirstOrDefaultAsync(m => m.PizzaID == id);

            if (Pizza == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Pizza = await _context.Pizza.FindAsync(id);

            if (Pizza != null)
            {
                _context.Pizza.Remove(Pizza);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
