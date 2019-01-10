using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Banking.CoreProcess;
using Banking.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Banking.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class TransactionController : ControllerBase
    {
        static MyDBContext context;
        private static readonly DbHelper dbHelper = new SQLServerDbHelper(context);
        private static readonly UserHelper userHelper = new UserHelper(dbHelper);
        private readonly TransactionHelper transactionHelper = new TransactionHelper();
        private static readonly BankAccountHelper bankAccountHelper = new BankAccountHelper(dbHelper);
        [Route("addTransaction")]
        [HttpPost]
        public IActionResult addTransaction(BankAccount sendAcc, BankAccount recAcc, string message, int amount)
            //truyen vao senAccId, recAccId, message, amount
        {
            var sendAccRemain = bankAccountHelper.getRemain(sendAcc.BankAccountId);
            if (sendAccRemain >= amount)
            {
                Transaction transaction = transactionHelper.createTransaction(sendAcc.BankAccountId, recAcc.BankAccountId,
                        message, amount);
                bankAccountHelper.addRemain(transaction.DeleteBankAccount, amount);
                bankAccountHelper.addRemain(transaction.ReceiveBankAccount, amount);
                transactionHelper.addTransaction(transaction);
                return Ok();
            }
            return BadRequest();
        }
    }
}