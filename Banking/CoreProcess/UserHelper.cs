using System;
using Banking.Models;

namespace Banking.CoreProcess
{
    public class UserHelper
    {
        private static string table = "User";
        private static string[] column= new string[] {"Id", "Username", "HashPassowrd", "Name", "Type", "Phone", "Balance"};
        private static string[] bankAccountColumn = new string[] {"BankAccountId", "UserId", "BankAccountName", "Balance" };
        private readonly DbHelper dbHelper;
        public UserHelper(SQLServerDbHelper _dbHelper)
        {
            dbHelper = _dbHelper;
        }

        internal void createUser(User user)
        {
            dbHelper.insert(table, UserHelper.column, new Object[] {user.Id, user.UserName, user.HashPassword, user.Name, user.Type.Id, user.Phone, user.Balance});
        }

        internal void addBankAccount(User user, BankAccount bankAccount)
        {
            bankAccount.UserId = user.Id;
            dbHelper.update("BankAccount", bankAccountColumn, new object[] { bankAccount.BankAccountId, bankAccount.UserId, bankAccount.BankAccountName, bankAccount.Balance });
        }
    }
}