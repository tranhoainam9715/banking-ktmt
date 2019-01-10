using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Banking.CoreProcess;
using Banking.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InternetBanking.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        static MyDBContext context;
        private static readonly DbHelper dbHelper = new SQLServerDbHelper(context);
        private static readonly UserHelper userHelper = new UserHelper(dbHelper);
        private readonly TransactionHelper transactionHelper = new TransactionHelper();
        private static readonly BankAccountHelper bankAccountHelper = new BankAccountHelper(dbHelper);

        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }

        ///user/login
        [Route("login")]
        [HttpPost]
        public IActionResult login([FromBody] User user)
        {
            userHelper.createUser(user);//userHelper was null
            return Ok("Done");
        }

        [Route("getAccountList")]
        [HttpPost]
        public List<int> getAccountList([FromBody] User user)
        { // truyen vao userId
            return userHelper.getAccountList(user.Id);
        }

        [Route("getAccountDetail")]
        [HttpPost]
        public BankAccount getAccountDetail([FromBody]User user, BankAccount bankAccount)//truyen vao userId, bankAccountId
        {
            return userHelper.getAccountDetail(user.Id, bankAccount.BankAccountId);
        }

        [Route("getHistory")]
        [HttpPost]
        public List<Transaction> getHistory(User user, BankAccount bankAccount)//truyen vao userId, bankAccountId
        {
            return transactionHelper.getHistory(user.Id, bankAccount.BankAccountId);
        }

        [Route("transferBanlance")]
        [HttpPost]
        public IActionResult transferBanlance(User user, BankAccount deleteAccount, BankAccount receiveAccount)//truyen userId, deleteAccountId, receiveAccountId
        {
            var accountList = userHelper.getAccountList(user.Id);
            if (accountList.FindIndex(a => a == deleteAccount.BankAccountId) >= 0 && accountList.FindIndex(a => a == deleteAccount.BankAccountId) >= 0)
            {
                var delRemain = bankAccountHelper.getRemain(deleteAccount.BankAccountId);
                //thuc hien chuyen tien con lai
                if (delRemain >= 50000)
                {
                    Transaction transaction = transactionHelper.createTransaction(deleteAccount.BankAccountId, receiveAccount.BankAccountId,
                        "transfer balance for account deleted", delRemain);
                    bankAccountHelper.addRemain(transaction.DeleteBankAccount, delRemain);
                    bankAccountHelper.addRemain(transaction.ReceiveBankAccount, delRemain);
                    transactionHelper.addTransaction(transaction);

                    return Ok();
                }
		    }
            return BadRequest();
        }
    } 
}