using System;

namespace Accounts.Service
{
    public class SavingsAccount:IAccount
    {
        public string GetType()
        {
            return "SAVINGS";
        }
    }
}