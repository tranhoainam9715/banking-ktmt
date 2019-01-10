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
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        static MyDBContext context;
        private static readonly DbHelper dbHelper = new SQLServerDbHelper(context);
        private static readonly UserHelper userHelper = new UserHelper(dbHelper);
        private readonly TransactionHelper transactionHelper = new TransactionHelper();
        private static readonly BankAccountHelper bankAccountHelper = new BankAccountHelper(dbHelper);

        [Route("getAccountInfomation")]
        [HttpPost]
        public IActionResult getAccountInformation(BankAccount bankAccount)//truyen vao bankAccountId
        {
            return bankAccountHelper.getAccountInformation(bankAccount.BankAccountId);
        }

        [Route("getRemain")]
        [HttpPost]
        public int getRemain(BankAccount bankAccount)//truyen vao bankAccountId
        {
            return bankAccountHelper.getRemain(bankAccount.BankAccountId);
        }
    }
}