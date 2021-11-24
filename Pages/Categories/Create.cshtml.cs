using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Repede_Calin_Lab8.Data;
using Repede_Calin_Lab8.Models;

namespace Repede_Calin_Lab8.Pages.Categories
{
    public class CreateModel : PageModel
    {
        private readonly Repede_Calin_Lab8.Data.Repede_Calin_Lab8Context _context;

        public CreateModel(Repede_Calin_Lab8.Data.Repede_Calin_Lab8Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Category Category { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Category.Add(Category);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
