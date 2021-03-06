﻿using DotNetRazorCRUD.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace DotNetRazorCRUD.Pages.Movies
{
    public class DetailsModel : PageModel
    {
        private readonly DotNetRazorCRUD.Models.DotNetRazorCRUDContext _context;

        public DetailsModel(DotNetRazorCRUD.Models.DotNetRazorCRUDContext context)
        {
            _context = context;
        }

        public Movie Movie { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                Movie =  await _context.Movie.FirstOrDefaultAsync();
            }
            else
            {
                Movie = await _context.Movie.FirstOrDefaultAsync(m => m.ID == id);
            }

            if (Movie == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
