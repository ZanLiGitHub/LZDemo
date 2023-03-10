using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using LZDemo.Data;
using LZDemo.Model;

namespace LZDemo.Pages._MoneyIn
{
    public class CreateModel : PageModel
    {
        private readonly LZDemo.Data.ApplicationDbContext _context;

        public CreateModel(LZDemo.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public MoneyIn MoneyIn { get; set; }
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.MoneyIn.Add(MoneyIn);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
