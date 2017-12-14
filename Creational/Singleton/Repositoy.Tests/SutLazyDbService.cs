using System;
using Repository;
using Xunit;

namespace Repositoy.Tests
{
    public class SutLazyDbService
    {
        [Fact]
        public void MultipleInstanceOfEagerDbServiceShouldbeSame()
        {
            var instance1 = LazyDbService.Instance;
            var instance2 = LazyDbService.Instance;
            
            Assert.Equal(instance1, instance2);
        }
    }
}
