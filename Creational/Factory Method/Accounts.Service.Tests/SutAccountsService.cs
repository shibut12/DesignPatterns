using System;
using Xunit;
using Accounts.Service;

namespace Accounts.Service.Tests
{
    public class SutAccountsService
    {
        [Fact]
        public void FactoryShouldCreateCheckingAccount()
        {
            var accountfactory = new Accounts();

            var checkingAccount = accountfactory.CreateAccount(0);

            Assert.Equal(checkingAccount.GetType(), "CHECKING");

        }
        [Fact]
        public void FactoryShouldCreateSavingAccount()
        {
            var accountfactory = new Accounts();

            var checkingAccount = accountfactory.CreateAccount(1);

            Assert.Equal(checkingAccount.GetType(), "SAVINGS");

        }
    }
}
