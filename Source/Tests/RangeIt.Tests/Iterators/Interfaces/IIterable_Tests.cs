namespace RangeIt.Tests.Iterators.Interfaces
{
    using FluentAssertions;
    using RangeIt.Iterators.Interfaces;
    using System.Linq;
    using Xunit;

    [Collection("IIterable.Tests")]
    public class IIterable_Tests
    {
        [Fact]
        public void Test_IIterable_Is_Interface()
        {
            typeof(IIterable).IsInterface.Should().BeTrue();
        }

        [Fact]
        public void Test_IIterable_Has_Previous_Method()
        {
            var methodInfo = typeof(IIterable).GetMethods()
                                              .Where(m => m.Name == "Previous")
                                              .FirstOrDefault();

            methodInfo.ReturnType.Should().Be(typeof(bool));
            methodInfo.GetParameters().Should().BeEmpty();
        }

        [Fact]
        public void Test_IIterable_Has_Next_Method()
        {
            var methodInfo = typeof(IIterable).GetMethods()
                                              .Where(m => m.Name == "Next")
                                              .FirstOrDefault();

            methodInfo.ReturnType.Should().Be(typeof(bool));
            methodInfo.GetParameters().Should().BeEmpty();
        }
    }
}
