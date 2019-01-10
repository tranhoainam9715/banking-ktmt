using System;
using Banking.Models;

namespace Banking.CoreProcess
{
    public class BankAccountHelper
    {
        private readonly DbHelper dbHelper;
        public BankAccountHelper(DbHelper _dbHelper)
        {
            dbHelper = _dbHelper;
        }
        internal static BankAccountHelper getInstance()
        {
            throw new NotImplementedException();
        }

        internal void createBankAccount(BankAccount bankAccount)
        {
            throw new NotImplementedException();
        }

        internal void deposit(BankAccount bankAccount, long amount)
        {
            throw new NotImplementedException();
        }
    }
}