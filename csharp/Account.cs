using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp
{
    public class AccountBuilder
    {
        public class Account
        {
            public int Balance { get; set; }
            public string Name { get; set; }
            public string Type { get; set; }



        }

        Account _account;
        AccountBuilder()
        {
            _account = new Account();
        }
        public static AccountBuilder DefaultAccount(string Name, int balance)
        {
            var accountBuilder = new AccountBuilder();
            accountBuilder._account.Balance = balance;
            accountBuilder._account.Name = Name;
            return accountBuilder;
        }
        public AccountBuilder AsVip()
        {
            _account.Type = "VIP";
            return this;
        }
        public Account Build()
        {
            return _account;
        }
    }
   
    
}
