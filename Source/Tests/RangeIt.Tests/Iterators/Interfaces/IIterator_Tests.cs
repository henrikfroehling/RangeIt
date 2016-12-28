namespace RangeIt.Tests.Iterators.Interfaces
{
    using FluentAssertions;
    using RangeIt.Iterators.Interfaces;
    using Xunit;

    [Collection("IIterator.Tests")]
    public class IIterator_Tests
    {
        [Fact]
        public void Test_IIterator_IsInterface()
        {
            typeof(IIterator).IsInterface.Should().BeTrue();
        }
    }
}
