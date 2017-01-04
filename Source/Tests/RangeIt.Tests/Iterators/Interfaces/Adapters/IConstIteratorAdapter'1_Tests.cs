namespace RangeIt.Tests.Iterators.Interfaces.Adapters
{
    using FluentAssertions;
    using RangeIt.Iterators.Interfaces;
    using RangeIt.Iterators.Interfaces.Adapters;
    using System.Collections.Generic;
    using Xunit;

    [Collection("IConstIteratorAdapter<T>.Tests")]
    public class IConstIteratorAdapter_1_Tests
    {
        [Fact]
        public void Test_IConstIteratorAdapter_1_Is_Interface()
        {
            typeof(IConstIteratorAdapter<>).IsInterface.Should().BeTrue();
        }

        [Fact]
        public void Test_IConstIteratorAdapter_1_Is_Generic()
        {
            typeof(IConstIteratorAdapter<>).ContainsGenericParameters.Should().BeTrue();
            typeof(IConstIteratorAdapter<int>).GenericTypeArguments.Should().NotBeEmpty().And.HaveCount(1);
        }

        [Fact]
        public void Test_IConstIteratorAdapter_1_DerivesFrom_IConstIterator_Interface()
        {
            typeof(IConstIteratorAdapter<int>).GetInterfaces().Should().Contain(typeof(IConstIterator<int>));
        }

        [Fact]
        public void Test_IConstIteratorAdapter_1_DerivesFrom_IIterable_Interface()
        {
            typeof(IConstIteratorAdapter<>).GetInterfaces().Should().Contain(typeof(IIterable));
        }

        [Fact]
        public void Test_IConstIteratorAdapter_1_DerivesFrom_IEnumerable_Interface()
        {
            typeof(IConstIteratorAdapter<int>).GetInterfaces().Should().Contain(typeof(IEnumerable<int>));
        }
    }
}
