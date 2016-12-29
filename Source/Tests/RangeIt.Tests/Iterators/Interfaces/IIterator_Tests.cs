namespace RangeIt.Tests.Iterators.Interfaces
{
    using FluentAssertions;
    using RangeIt.Iterators.Interfaces;
    using System.Collections;
    using System.Linq;
    using Xunit;

    [Collection("IIterator.Tests")]
    public class IIterator_Tests
    {
        [Fact]
        public void Test_IIterator_Is_Interface()
        {
            typeof(IIterator).IsInterface.Should().BeTrue();
        }

        [Fact]
        public void Test_IIterator_DerivesFrom_IIterable_Interface()
        {
            typeof(IIterator).GetInterfaces().Should().Contain(typeof(IIterable));
        }

        [Fact]
        public void Test_IIterator_DerivesFrom_IEnumerable_Interface()
        {
            typeof(IIterator).GetInterfaces().Should().Contain(typeof(IEnumerable));
        }

        [Fact]
        public void Test_IIterator_Has_Current_Property()
        {
            var uriTemplatePropertyInfo = typeof(IIterator).GetProperties()
                                                           .Where(p => p.Name == "Current")
                                                           .FirstOrDefault();

            uriTemplatePropertyInfo.CanRead.Should().BeTrue();
            uriTemplatePropertyInfo.CanWrite.Should().BeTrue();
            uriTemplatePropertyInfo.PropertyType.Should().Be(typeof(object));
        }
    }
}
