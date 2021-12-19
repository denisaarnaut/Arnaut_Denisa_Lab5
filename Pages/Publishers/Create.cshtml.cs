using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Arnaut_Denisa_Lab5.Data;
using Arnaut_Denisa_Lab5.Models;

namespace Arnaut_Denisa_Lab5.Pages.Publishers
{
    public class CreateModel : PageModel
    {
        private readonly Arnaut_Denisa_Lab5.Data.Arnaut_Denisa_Lab5Context _context;

        public CreateModel(Arnaut_Denisa_Lab5.Data.Arnaut_Denisa_Lab5Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Publisher Publisher { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Publisher.Add(Publisher);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
