using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Pizza_Projektet___cafe_luccas.Models;

namespace Pizza_Projektet___cafe_luccas.Pages.Forms
{
    public class SearchModel : PageModel
    {
        [BindProperty]
        // properties reaching the SearchModel Class
        public SearchModel Searching { get; set; }
        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid == false)
            {
                return Page();
            }

            return RedirectToPage("./Index");
        }
    }
}
