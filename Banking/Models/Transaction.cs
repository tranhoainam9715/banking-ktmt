using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Banking.Models
{
    public class Transaction
    {
        public int TransactionId { get; set; }
        public int BankAccountId { get; set; }
        public int FromBankAccountId { get; set; }
        public int ToBankAccountId { get; set; }
        public long Amount { get; set; }
        public string TransactionHash { get; set; }
        public string Message { get; set; }

    }
}
