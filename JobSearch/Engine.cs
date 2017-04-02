using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobSearch
{
    class Engine
    {
        public static Account CreateAccount(string emailAddress, AccountType typeOfAccount)
        {
            var account = new Account
            {
                EmailAddress = emailAddress,
                TypeOfAccount = typeOfAccount
            };
            return account;
        }
    }
}
