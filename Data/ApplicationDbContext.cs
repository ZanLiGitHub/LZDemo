using LZDemo.Model;
using Microsoft.EntityFrameworkCore;

namespace LZDemo.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {

        }

        public DbSet<MoneyIn> MoneyIn { get; set; }

        public DbSet<LZDemo.Model.BankAccount> BankAccount { get; set; }
    }
}
