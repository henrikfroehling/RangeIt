namespace RangeIt.Tests.Iterators.Interfaces
{
    using FluentAssertions;
    using RangeIt.Iterators.Interfaces;
    using System.Collections.Generic;
    using System.Linq;
    using Xunit;

    [Collection("IConstIterator<T>.Tests")]
    public class IConstIterator_1_Tests
    {
        [Fact]
        public void Test_IConstIterator_1_Is_Interface()
        {
            typeof(IConstIterator<>).IsInterface.Should().BeTrue();
        }

        [Fact]
        public void Test_IConstIterator_1_Is_Generic()
        {
            typeof(IConstIterator<>).ContainsGenericParameters.Should().BeTrue();
            typeof(IConstIterator<int>).GenericTypeArguments.Should().NotBeEmpty().And.HaveCount(1);
        }

        [Fact]
        public void Test_IConstIterator_1_DerivesFrom_IIterable_Interface()
        {
            typeof(IConstIterator<>).GetInterfaces().Should().Contain(typeof(IIterable));
        }

        [Fact]
        public void Test_IConstIterator_1_DerivesFrom_IEnumerable_1_Interface()
        {
            typeof(IConstIterator<int>).GetInterfaces().Should().Contain(typeof(IEnumerable<int>));
        }

        [Fact]
        public void Test_IConstIterator_1_Has_Current_Property()
        {
            var uriTemplatePropertyInfo = typeof(IConstIterator<int>).GetProperties()
                                                                     .Where(p => p.Name == "Current")
                                                                     .FirstOrDefault();

            uriTemplatePropertyInfo.CanRead.Should().BeTrue();
            uriTemplatePropertyInfo.CanWrite.Should().BeFalse();
            uriTemplatePropertyInfo.PropertyType.Should().Be(typeof(int));
        }
    }
}
