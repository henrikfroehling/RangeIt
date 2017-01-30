namespace RangeIt.Tests.Iterators.Interfaces
{
    using FluentAssertions;
    using RangeIt.Iterators.Interfaces;
    using System.Linq;
    using Traits;
    using Xunit;

    [Category("Iterators.Interfaces.IConstIterator<T>")]
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
