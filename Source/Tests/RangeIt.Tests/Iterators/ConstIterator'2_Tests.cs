namespace RangeIt.Tests.Iterators
{
    using FluentAssertions;
    using RangeIt.Iterators;
    using Xunit;

    [Collection("ConstIterator<T, U>.Tests")]
    public class ConstIterator_2_Tests
    {
        [Fact]
        public void Test_ConstIterator_2_IsNot_Abstract()
        {
            typeof(ConstIterator<,>).IsAbstract.Should().BeFalse();
        }

        [Fact]
        public void Test_ConstIterator_2_Is_Sealed()
        {
            typeof(ConstIterator<,>).IsSealed.Should().BeTrue();
        }

        [Fact]
        public void Test_ConstIterator_2_Is_Generic()
        {
            typeof(ConstIterator<,>).ContainsGenericParameters.Should().BeTrue();
            typeof(ConstIterator<int, float>).GenericTypeArguments.Should().NotBeEmpty().And.HaveCount(2);
        }
    }
}
