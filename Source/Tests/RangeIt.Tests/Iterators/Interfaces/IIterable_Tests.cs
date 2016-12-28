namespace RangeIt.Tests.Iterators.Interfaces
{
    using FluentAssertions;
    using RangeIt.Iterators.Interfaces;
    using Xunit;

    [Collection("IIterable.Tests")]
    public class IIterable_Tests
    {
        [Fact]
        public void Test_IIterable_IsInterface()
        {
            typeof(IIterable).IsInterface.Should().BeTrue();
        }
    }
}
