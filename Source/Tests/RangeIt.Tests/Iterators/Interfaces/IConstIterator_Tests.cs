namespace RangeIt.Tests.Iterators.Interfaces
{
    using FluentAssertions;
    using RangeIt.Iterators.Interfaces;
    using System.Collections;
    using Xunit;

    [Collection("IConstIterator.Tests")]
    public class IConstIterator_Tests
    {
        [Fact]
        public void Test_IConstIterator_Is_Interface()
        {
            typeof(IConstIterator).IsInterface.Should().BeTrue();
        }

        [Fact]
        public void Test_IConstIterator_DerivesFrom_IIterable_Interface()
        {
            typeof(IConstIterator).GetInterfaces().Should().Contain(typeof(IIterable));
        }

        [Fact]
        public void Test_IConstIterator_DerivesFrom_IEnumerable_Interface()
        {
            typeof(IConstIterator).GetInterfaces().Should().Contain(typeof(IEnumerable));
        }
    }
}
