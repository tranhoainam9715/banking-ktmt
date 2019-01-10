using System.Collections.Generic;

namespace Banking.Models
{
    public class BankAccount
    {
        public int BankAccountId { get; set; }
        public int UserId { get; set; }
        public string BankAccountName { get; set; }
        public long Balance { get; set; }
        public List<Transaction> Transactions { get; set; }

    }
}