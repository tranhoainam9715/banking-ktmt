using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Banking.Models
{
    public class UserType
    {
        public UserType(int id)
        {
            switch(id)
            {
                case 1:
                    Id = 1;
                    Name = "Admin";
                    break;
                case 2:
                    Id = 2;
                    Name = "Customer";
                    break;
            }
        }
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
