namespace RangeIt.Tests.Iterators
{
    using FluentAssertions;
    using RangeIt.Iterators;
    using Xunit;

    [Collection("ConstIterator.Tests")]
    public class ConstIterator_Tests
    {
        [Fact]
        public void Test_ConstIterator_IsNot_Abstract()
        {
            typeof(ConstIterator).IsAbstract.Should().BeFalse();
        }

        [Fact]
        public void Test_ConstIterator_Is_Sealed()
        {
            typeof(ConstIterator).IsSealed.Should().BeTrue();
        }
    }
}
