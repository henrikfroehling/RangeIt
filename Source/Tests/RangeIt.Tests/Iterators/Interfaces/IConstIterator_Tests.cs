namespace RangeIt.Tests.Iterators.Interfaces
{
    using FluentAssertions;
    using RangeIt.Iterators.Interfaces;
    using System.Collections;
    using System.Linq;
    using Xunit;

    [Collection("IConstIterator.Tests")]
    public class IConstIterator_Tests
    {
        [Fact]
        public void Test_IConstIterator_Is_Interface()
        {
            typeof(IConstIterator).IsInterface.Should().BeTrue();
        }

        [Fact]
        public void Test_IConstIterator_DerivesFrom_IIterable_Interface()
        {
            typeof(IConstIterator).GetInterfaces().Should().Contain(typeof(IIterable));
        }

        [Fact]
        public void Test_IConstIterator_DerivesFrom_IEnumerable_Interface()
        {
            typeof(IConstIterator).GetInterfaces().Should().Contain(typeof(IEnumerable));
        }

        [Fact]
        public void Test_IConstIterator_Has_Current_Property()
        {
            var uriTemplatePropertyInfo = typeof(IConstIterator).GetProperties()
                                                                .Where(p => p.Name == "Current")
                                                                .FirstOrDefault();

            uriTemplatePropertyInfo.CanRead.Should().BeTrue();
            uriTemplatePropertyInfo.CanWrite.Should().BeFalse();
            uriTemplatePropertyInfo.PropertyType.Should().Be(typeof(object));
        }
    }
}
