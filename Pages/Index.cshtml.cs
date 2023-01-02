using LZDemo.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LZDemo.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly LZDemo.Data.ApplicationDbContext _context;

        public IndexModel(ILogger<IndexModel> logger, LZDemo.Data.ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IList<MoneyIn> MoneyIn { get; set; } = default!;
        public IList<BankAccount> BankAccount { get; set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.MoneyIn != null)
            {
                MoneyIn = await _context.MoneyIn.ToListAsync();
            }
            if (_context.BankAccount != null)
            {
                BankAccount = await _context.BankAccount.ToListAsync();
            }

        }
    }
}