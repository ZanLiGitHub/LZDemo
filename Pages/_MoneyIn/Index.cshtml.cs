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
    public class IndexModel : PageModel
    {
        private readonly LZDemo.Data.ApplicationDbContext _context;

        public IndexModel(LZDemo.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<MoneyIn> MoneyIn { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.MoneyIn != null)
            {
                MoneyIn = await _context.MoneyIn.ToListAsync();
            }
        }
    }
}
