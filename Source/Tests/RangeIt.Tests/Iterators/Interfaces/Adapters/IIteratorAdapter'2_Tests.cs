namespace RangeIt.Tests.Iterators.Interfaces.Adapters
{
    using FluentAssertions;
    using RangeIt.Iterators.Interfaces;
    using RangeIt.Iterators.Interfaces.Adapters;
    using System.Collections.Generic;
    using Traits;
    using Xunit;

    [Category("Iterators.Interfaces.Adaptars.IIteratorAdapter<T, U>")]
    public class IIteratorAdapter_2_Tests
    {
        [Fact]
        public void Test_IIteratorAdapter_2_Is_Interface()
        {
            typeof(IIteratorAdapter<,>).IsInterface.Should().BeTrue();
        }

        [Fact]
        public void Test_IIteratorAdapter_2_Is_Generic()
        {
            typeof(IIteratorAdapter<,>).ContainsGenericParameters.Should().BeTrue();
            typeof(IIteratorAdapter<int, float>).GenericTypeArguments.Should().NotBeEmpty().And.HaveCount(2);
        }

        [Fact]
        public void Test_IIteratorAdapter_2_DerivesFrom_IIterator_Interface()
        {
            typeof(IIteratorAdapter<int, float>).GetInterfaces().Should().Contain(typeof(IIterator<int, float>));
        }

        [Fact]
        public void Test_IIteratorAdapter_2_DerivesFrom_IIterable_Interface()
        {
            typeof(IIteratorAdapter<,>).GetInterfaces().Should().Contain(typeof(IIterable));
        }

        [Fact]
        public void Test_IIteratorAdapter_2_DerivesFrom_IEnumerable_Interface()
        {
            typeof(IIteratorAdapter<int, float>).GetInterfaces().Should().Contain(typeof(IEnumerable<KeyValuePair<int, float>>));
        }
    }
}
