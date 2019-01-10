using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Banking.Models
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string HashPassword { get; set; }
        public string Name { get; set; }
        public UserType Type { get; set; }
        public string Phone { get; set; }
        public List<BankAccount> BankAccounts { get; set; }
        public long Balance { get; set; }
        public void DataBind(string[] column, object[] value)
        {
            for (int i = 0; i < column.Length; i++)
            {
                switch(column[i])
                {

                    case "Id":
                        this.Id = (int)value[i];
                        break;

                    case "UserName":
                        this.UserName = (string)value[i];
                        break;

                    case "HashPassword":
                        this.HashPassword = (string)value[i];
                        break;
                    case "Name":
                        this.Name = (string)value[i];
                        break;
                    case "Type":
                        this.Type = new UserType((int)value[i]);
                        break;
                    case "Phone":
                        this.Phone = (string)value[i];
                        break;
                    case "Balance":
                        this.Balance = (long)value[i];
                        break;
                }
            }
        }
    }
}
