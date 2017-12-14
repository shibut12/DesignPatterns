using System;

namespace Accounts.Service
{
    public class CheckingAccount:IAccount
    {
        public string GetType()
        {
            return    "CHECKING";
        }
    }
}