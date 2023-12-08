using Microsoft.EntityFrameworkCore;
using Expense_Tracker.Models;
namespace Expense_Tracker.Context
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Transaction> TransactionSet { get; set; }
        public DbSet<Category> CategorySet { get; set; }
    }
}
