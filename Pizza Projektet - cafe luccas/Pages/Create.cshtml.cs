using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Pizza_Projektet___cafe_luccas.Data;
using Pizza_Projektet___cafe_luccas.Models;

namespace Pages
{
    public class CreateModel : PageModel
    {
        private readonly Pizza_Projektet___cafe_luccas.Data.Pizza_Projektet___cafe_luccasContext _context;

        public CreateModel(Pizza_Projektet___cafe_luccas.Data.Pizza_Projektet___cafe_luccasContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public PizzaMenu PizzaMenu { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.PizzaMenu.Add(PizzaMenu);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
