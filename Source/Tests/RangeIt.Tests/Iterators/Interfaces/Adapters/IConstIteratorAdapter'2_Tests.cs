namespace RangeIt.Tests.Iterators.Interfaces.Adapters
{
    using FluentAssertions;
    using RangeIt.Iterators.Interfaces;
    using RangeIt.Iterators.Interfaces.Adapters;
    using System.Collections.Generic;
    using Xunit;

    [Collection("IConstIteratorAdapter<T, U>.Tests")]
    public class IConstIteratorAdapter_2_Tests
    {
        [Fact]
        public void Test_IConstIteratorAdapter_2_Is_Interface()
        {
            typeof(IConstIteratorAdapter<,>).IsInterface.Should().BeTrue();
        }

        [Fact]
        public void Test_IConstIteratorAdapter_2_Is_Generic()
        {
            typeof(IConstIteratorAdapter<,>).ContainsGenericParameters.Should().BeTrue();
            typeof(IConstIteratorAdapter<int, float>).GenericTypeArguments.Should().NotBeEmpty().And.HaveCount(2);
        }

        [Fact]
        public void Test_IConstIteratorAdapter_2_DerivesFrom_IConstIterator_Interface()
        {
            typeof(IConstIteratorAdapter<int, float>).GetInterfaces().Should().Contain(typeof(IConstIterator<int, float>));
        }

        [Fact]
        public void Test_IConstIteratorAdapter_2_DerivesFrom_IIterable_Interface()
        {
            typeof(IConstIteratorAdapter<,>).GetInterfaces().Should().Contain(typeof(IIterable));
        }

        [Fact]
        public void Test_IConstIteratorAdapter_2_DerivesFrom_IEnumerable_Interface()
        {
            typeof(IConstIteratorAdapter<int, float>).GetInterfaces().Should().Contain(typeof(IEnumerable<KeyValuePair<int, float>>));
        }
    }
}
