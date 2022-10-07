﻿using System;
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
    public class IndexModel : PageModel
    {
        private readonly Pizza_Projektet___cafe_luccas.Data.Pizza_Projektet___cafe_luccasContext _context;

        public IndexModel(Pizza_Projektet___cafe_luccas.Data.Pizza_Projektet___cafe_luccasContext context)
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
