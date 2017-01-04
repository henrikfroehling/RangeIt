namespace RangeIt.Tests.Iterators.Interfaces.Adapters
{
    using FluentAssertions;
    using RangeIt.Iterators.Interfaces;
    using RangeIt.Iterators.Interfaces.Adapters;
    using System.Collections;
    using Xunit;

    [Collection("IIteratorAdapter.Tests")]
    public class IIteratorAdapter_Tests
    {
        [Fact]
        public void Test_IIteratorAdapter_Is_Interface()
        {
            typeof(IIteratorAdapter).IsInterface.Should().BeTrue();
        }

        [Fact]
        public void Test_IIteratorAdapter_DerivesFrom_IIterator_Interface()
        {
            typeof(IIteratorAdapter).GetInterfaces().Should().Contain(typeof(IIterator));
        }

        [Fact]
        public void Test_IIteratorAdapter_DerivesFrom_IIterable_Interface()
        {
            typeof(IIteratorAdapter).GetInterfaces().Should().Contain(typeof(IIterable));
        }

        [Fact]
        public void Test_IIteratorAdapter_DerivesFrom_IEnumerable_Interface()
        {
            typeof(IIteratorAdapter).GetInterfaces().Should().Contain(typeof(IEnumerable));
        }
    }
}
