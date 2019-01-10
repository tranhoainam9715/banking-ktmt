using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Banking.Models
{
    public class MyDBContext: DbContext
    {
        public MyDBContext(DbContextOptions<MyDBContext> options) : base(options) { }
        public DbSet<User> Users { get; set; }
        public DbSet<BankAccount> BankAccounts  { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
    }
}
