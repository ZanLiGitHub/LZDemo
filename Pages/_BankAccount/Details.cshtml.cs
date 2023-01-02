using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using LZDemo.Data;
using LZDemo.Model;

namespace LZDemo.Pages._BankAccount
{
    public class DetailsModel : PageModel
    {
        private readonly LZDemo.Data.ApplicationDbContext _context;

        public DetailsModel(LZDemo.Data.ApplicationDbContext context)
        {
            _context = context;
        }

      public BankAccount BankAccount { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.BankAccount == null)
            {
                return NotFound();
            }

            var bankaccount = await _context.BankAccount.FirstOrDefaultAsync(m => m.Id == id);
            if (bankaccount == null)
            {
                return NotFound();
            }
            else 
            {
                BankAccount = bankaccount;
            }
            return Page();
        }
    }
}
