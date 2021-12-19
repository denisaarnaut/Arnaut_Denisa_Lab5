using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Arnaut_Denisa_Lab5.Data;
using Arnaut_Denisa_Lab5.Models;

namespace Arnaut_Denisa_Lab5.Pages.Books
{
    public class IndexModel : PageModel
    {
        private readonly Arnaut_Denisa_Lab5.Data.Arnaut_Denisa_Lab5Context _context;

        public IndexModel(Arnaut_Denisa_Lab5.Data.Arnaut_Denisa_Lab5Context context)
        {
            _context = context;
        }

        public IList<Book> Book { get;set; }

        public async Task OnGetAsync()
        {
            Book = await _context.Book
                .Include(b => b.Publisher)
                .ToListAsync();
        }
    }
}
