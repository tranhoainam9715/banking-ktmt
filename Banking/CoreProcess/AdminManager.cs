using Banking.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Banking.CoreProcess
{
    public class AdminManager
    {
        private readonly UserHelper userHelper;
        private readonly BankAccountHelper bankAccountHelper;

       
        public AdminManager(UserHelper _userHelper, BankAccountHelper _bankAccountHelper)
        {
            userHelper = _userHelper;
            bankAccountHelper = _bankAccountHelper;
        }

        public void createUser(User user)
        {
           userHelper.createUser(user);
        }
        public void createBankAccount(User user, BankAccount bankAccount)
        {

            bankAccountHelper.createBankAccount(bankAccount);
            userHelper.addBankAccount(user, bankAccount);
        }
        public void deposit(BankAccount bankAccount, long amount)
        {
            bankAccountHelper.deposit(bankAccount, amount);
        }
    }
}
