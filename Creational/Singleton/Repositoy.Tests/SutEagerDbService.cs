using System;
using Repository;
using Xunit;

namespace Repositoy.Tests
{
    public class SutEagerDbService
    {
        [Fact]
        public void MultipleInstanceOfEagerDbServiceShouldbeSame()
        {
            var instance1 = EagerDbService.Instance;
            var instance2 = EagerDbService.Instance;
            
            Assert.Equal(instance1, instance2);
        }
    }
}
