using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using LZDemo.Data;
using LZDemo.Model;

namespace LZDemo.Pages._MoneyIn
{
    public class EditModel : PageModel
    {
        private readonly LZDemo.Data.ApplicationDbContext _context;

        public EditModel(LZDemo.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public MoneyIn MoneyIn { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.MoneyIn == null)
            {
                return NotFound();
            }

            var moneyin =  await _context.MoneyIn.FirstOrDefaultAsync(m => m.Id == id);
            if (moneyin == null)
            {
                return NotFound();
            }
            MoneyIn = moneyin;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(MoneyIn).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MoneyInExists(MoneyIn.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool MoneyInExists(int id)
        {
          return _context.MoneyIn.Any(e => e.Id == id);
        }
    }
}
