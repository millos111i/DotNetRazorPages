using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace DotNetRazorCRUD.Models
{
    public class DotNetRazorCRUDContext : DbContext
    {
        public DotNetRazorCRUDContext (DbContextOptions<DotNetRazorCRUDContext> options)
            : base(options)
        {
        }

        public DbSet<DotNetRazorCRUD.Models.Movie> Movie { get; set; }
    }
}
