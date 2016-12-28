namespace RangeIt.Tests.Iterators.Interfaces
{
    using FluentAssertions;
    using RangeIt.Iterators.Interfaces;
    using Xunit;

    [Collection("IConstIterator<T, U>.Tests")]
    public class IConstIterator_2_Tests
    {
        [Fact]
        public void Test_IConstIterator_2_Is_Interface()
        {
            typeof(IConstIterator<,>).IsInterface.Should().BeTrue();
        }

        [Fact]
        public void Test_IConstIterator_2_Is_Generic()
        {
            typeof(IConstIterator<,>).ContainsGenericParameters.Should().BeTrue();
            typeof(IConstIterator<int, float>).GenericTypeArguments.Should().NotBeEmpty().And.HaveCount(2);
        }
    }
}
