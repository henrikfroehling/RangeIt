namespace RangeIt.Tests.Iterators.Interfaces
{
    using FluentAssertions;
    using RangeIt.Iterators.Interfaces;
    using System.Collections;
    using Xunit;

    [Collection("IIterator.Tests")]
    public class IIterator_Tests
    {
        [Fact]
        public void Test_IIterator_IsInterface()
        {
            typeof(IIterator).IsInterface.Should().BeTrue();
        }

        [Fact]
        public void Test_IIterator_DerivesFrom_IIterable_Interface()
        {
            typeof(IIterator).GetInterfaces().Should().Contain(typeof(IIterable));
        }

        [Fact]
        public void Test_IIterator_DerivesFrom_IEnumerable_Interface()
        {
            typeof(IIterator).GetInterfaces().Should().Contain(typeof(IEnumerable));
        }
    }
}
