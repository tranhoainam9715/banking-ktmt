using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Banking.Models
{
    public class Transaction
    {
        private int deleteBankAccount;
        private int receiveBankAccount;
        private string message;
        private int delRemain;

        public int TransactionId { get; set; }
        public int BankAccountId { get; set; }
        public int FromBankAccountId { get; set; }
        public int ToBankAccountId { get; set; }
        public long Amount { get; set; }
        public string TransactionHash { get; set; }
        public string Message { get; set; }
        public int DeleteBankAccount { get => deleteBankAccount; set => deleteBankAccount = value; }
        public int ReceiveBankAccount { get => receiveBankAccount; set => receiveBankAccount = value; }
    }
}
