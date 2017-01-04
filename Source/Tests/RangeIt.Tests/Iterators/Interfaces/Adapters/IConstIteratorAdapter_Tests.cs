namespace RangeIt.Tests.Iterators.Interfaces.Adapters
{
    using FluentAssertions;
    using RangeIt.Iterators.Interfaces;
    using RangeIt.Iterators.Interfaces.Adapters;
    using System.Collections;
    using Xunit;

    [Collection("IConstIteratorAdapter.Tests")]
    public class IConstIteratorAdapter_Tests
    {
        [Fact]
        public void Test_IConstIteratorAdapter_Is_Interface()
        {
            typeof(IConstIteratorAdapter).IsInterface.Should().BeTrue();
        }

        [Fact]
        public void Test_IConstIteratorAdapter_DerivesFrom_IConstIterator_Interface()
        {
            typeof(IConstIteratorAdapter).GetInterfaces().Should().Contain(typeof(IConstIterator));
        }

        [Fact]
        public void Test_IConstIteratorAdapter_DerivesFrom_IIterable_Interface()
        {
            typeof(IConstIteratorAdapter).GetInterfaces().Should().Contain(typeof(IIterable));
        }

        [Fact]
        public void Test_IConstIteratorAdapter_DerivesFrom_IEnumerable_Interface()
        {
            typeof(IConstIteratorAdapter).GetInterfaces().Should().Contain(typeof(IEnumerable));
        }
    }
}
