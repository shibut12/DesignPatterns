using System;

namespace Accounts.Service
{
    public abstract class AccountsAbstract
    {
        public abstract IAccount CreateAccount(int type);
    }
}