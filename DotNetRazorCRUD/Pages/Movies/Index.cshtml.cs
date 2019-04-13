using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DotNetRazorCRUD.Models;

namespace DotNetRazorCRUD.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly DotNetRazorCRUD.Models.DotNetRazorCRUDContext _context;

        public IndexModel(DotNetRazorCRUD.Models.DotNetRazorCRUDContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; }

        public async Task OnGetAsync()
        {
            Movie = await _context.Movie.ToListAsync();
        }
    }
}
