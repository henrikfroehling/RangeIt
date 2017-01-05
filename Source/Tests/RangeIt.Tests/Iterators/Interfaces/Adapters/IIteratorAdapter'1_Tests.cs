namespace RangeIt.Tests.Iterators.Interfaces.Adapters
{
    using FluentAssertions;
    using RangeIt.Iterators.Interfaces;
    using RangeIt.Iterators.Interfaces.Adapters;
    using System.Collections.Generic;
    using Xunit;

    [Collection("IIteratorAdapter<T>.Tests")]
    public class IIteratorAdapter_1_Tests
    {
        [Fact]
        public void Test_IIteratorAdapter_1_Is_Interface()
        {
            typeof(IIteratorAdapter<>).IsInterface.Should().BeTrue();
        }

        [Fact]
        public void Test_IIteratorAdapter_1_Is_Generic()
        {
            typeof(IIteratorAdapter<>).ContainsGenericParameters.Should().BeTrue();
            typeof(IIteratorAdapter<int>).GenericTypeArguments.Should().NotBeEmpty().And.HaveCount(1);
        }

        [Fact]
        public void Test_IIteratorAdapter_1_DerivesFrom_IIterator_Interface()
        {
            typeof(IIteratorAdapter<int>).GetInterfaces().Should().Contain(typeof(IIterator<int>));
        }

        [Fact]
        public void Test_IIteratorAdapter_1_DerivesFrom_IIterable_Interface()
        {
            typeof(IIteratorAdapter<>).GetInterfaces().Should().Contain(typeof(IIterable));
        }

        [Fact]
        public void Test_IIteratorAdapter_1_DerivesFrom_IEnumerable_Interface()
        {
            typeof(IIteratorAdapter<int>).GetInterfaces().Should().Contain(typeof(IEnumerable<int>));
        }
    }
}
