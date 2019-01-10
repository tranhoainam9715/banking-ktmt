using Banking.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Banking.CoreProcess
{
    public class SQLServerDbHelper : DbHelper
    {
        private readonly MyDBContext _context;
        public SQLServerDbHelper(MyDBContext context)
        {
            _context = context;
        }
        public void insert(string table, string[] column, object[] value)
        {
            switch(table)
            {
                case "User":
                    User user = new User();
                    user.DataBind(column, value);
                    _context.Users.Add(user);
                    _context.SaveChanges();
                    break;
            }
        }

        public void update(string v1, string[] bankAccountColumn, object[] v2)
        {
            throw new NotImplementedException();
        }
    }
}
