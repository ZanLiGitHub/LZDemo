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
    public class IndexModel : PageModel
    {
        private readonly LZDemo.Data.ApplicationDbContext _context;

        public IndexModel(LZDemo.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<BankAccount> BankAccount { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.BankAccount != null)
            {
                BankAccount = await _context.BankAccount.ToListAsync();
            }
        }
    }
}
