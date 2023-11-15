﻿using Microsoft.EntityFrameworkCore;

namespace Expense_Tracker.Models
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
