namespace RangeIt.Tests.Iterators
{
    using FluentAssertions;
    using RangeIt.Iterators;
    using RangeIt.Iterators.Interfaces;
    using Xunit;

    [Collection("Iterator<T, U>.Tests")]
    public class Iterator_2_Tests
    {
        [Fact]
        public void Test_Iterator_2_IsNot_Abstract()
        {
            typeof(Iterator<,>).IsAbstract.Should().BeFalse();
        }

        [Fact]
        public void Test_Iterator_2_Is_Sealed()
        {
            typeof(Iterator<,>).IsSealed.Should().BeTrue();
        }

        [Fact]
        public void Test_Iterator_2_Is_Generic()
        {
            typeof(Iterator<,>).ContainsGenericParameters.Should().BeTrue();
            typeof(Iterator<int, float>).GenericTypeArguments.Should().NotBeEmpty().And.HaveCount(2);
        }

        [Fact]
        public void Test_Iterator_2_DerivesFrom_IIterator_2_Interface()
        {
            typeof(Iterator<int, float>).GetInterfaces().Should().Contain(typeof(IIterator<int, float>));
        }
    }
}
