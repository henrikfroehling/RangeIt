namespace RangeIt.Tests.Iterators.Interfaces
{
    using FluentAssertions;
    using RangeIt.Iterators.Interfaces;
    using Xunit;

    [Collection("IConstIterator.Tests")]
    public class IConstIterator_Tests
    {
        [Fact]
        public void Test_IConstIterator_Is_Interface()
        {
            typeof(IConstIterator).IsInterface.Should().BeTrue();
        }
    }
}
