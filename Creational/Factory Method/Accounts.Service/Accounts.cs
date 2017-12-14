using System;

namespace Accounts.Service
{
    public class Accounts:AccountsAbstract
    {
        public override IAccount CreateAccount(int type)
        {
            switch(type)
            {
                case 0:
                    return new CheckingAccount();
                case 1: 
                    return new SavingsAccount();
                default:
                    throw new System.InvalidOperationException("Incorrect account request");
            }
        }
    }
}
