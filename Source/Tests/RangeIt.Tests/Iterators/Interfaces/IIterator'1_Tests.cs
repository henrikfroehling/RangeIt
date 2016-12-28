namespace RangeIt.Tests.Iterators.Interfaces
{
    using FluentAssertions;
    using RangeIt.Iterators.Interfaces;
    using Xunit;

    [Collection("IIterator<T>.Tests")]
    public class IIterator_1_Tests
    {
        [Fact]
        public void Test_IIterator_1_Is_Interface()
        {
            typeof(IIterator<>).IsInterface.Should().BeTrue();
        }
    }
}
