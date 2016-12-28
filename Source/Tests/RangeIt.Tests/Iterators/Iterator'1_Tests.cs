namespace RangeIt.Tests.Iterators
{
    using FluentAssertions;
    using RangeIt.Iterators;
    using Xunit;

    [Collection("Iterator<T>.Tests")]
    public class Iterator_1_Tests
    {
        [Fact]
        public void Test_Iterator_1_IsNot_Abstract()
        {
            typeof(Iterator<>).IsAbstract.Should().BeFalse();
        }

        [Fact]
        public void Test_Iterator_1_Is_Sealed()
        {
            typeof(Iterator<>).IsSealed.Should().BeTrue();
        }

        [Fact]
        public void Test_Iterator_1_Is_Generic()
        {
            typeof(Iterator<>).ContainsGenericParameters.Should().BeTrue();
            typeof(Iterator<int>).GenericTypeArguments.Should().NotBeEmpty().And.HaveCount(1);
        }
    }
}
