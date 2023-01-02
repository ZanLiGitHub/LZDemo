using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using LZDemo.Data;
using LZDemo.Model;

namespace LZDemo.Pages._MoneyIn
{
    public class DetailsModel : PageModel
    {
        private readonly LZDemo.Data.ApplicationDbContext _context;

        public DetailsModel(LZDemo.Data.ApplicationDbContext context)
        {
            _context = context;
        }

      public MoneyIn MoneyIn { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.MoneyIn == null)
            {
                return NotFound();
            }

            var moneyin = await _context.MoneyIn.FirstOrDefaultAsync(m => m.Id == id);
            if (moneyin == null)
            {
                return NotFound();
            }
            else 
            {
                MoneyIn = moneyin;
            }
            return Page();
        }
    }
}
