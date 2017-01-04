namespace RangeIt.Tests.Iterators.Interfaces
{
    using FluentAssertions;
    using RangeIt.Iterators.Interfaces;
    using System.Collections.Generic;
    using System.Linq;
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

        [Fact]
        public void Test_IConstIterator_2_Has_Current_Property()
        {
            var uriTemplatePropertyInfo = typeof(IConstIterator<int, float>).GetProperties()
                                                                            .Where(p => p.Name == "Current")
                                                                            .FirstOrDefault();

            uriTemplatePropertyInfo.CanRead.Should().BeTrue();
            uriTemplatePropertyInfo.CanWrite.Should().BeFalse();
            uriTemplatePropertyInfo.PropertyType.Should().Be(typeof(KeyValuePair<int, float>));
        }

        [Fact]
        public void Test_IConstIterator_2_Has_Key_Property()
        {
            var uriTemplatePropertyInfo = typeof(IConstIterator<int, float>).GetProperties()
                                                                            .Where(p => p.Name == "Key")
                                                                            .FirstOrDefault();

            uriTemplatePropertyInfo.CanRead.Should().BeTrue();
            uriTemplatePropertyInfo.CanWrite.Should().BeFalse();
            uriTemplatePropertyInfo.PropertyType.Should().Be(typeof(int));
        }

        [Fact]
        public void Test_IConstIterator_2_Has_Value_Property()
        {
            var uriTemplatePropertyInfo = typeof(IConstIterator<int, float>).GetProperties()
                                                                            .Where(p => p.Name == "Value")
                                                                            .FirstOrDefault();

            uriTemplatePropertyInfo.CanRead.Should().BeTrue();
            uriTemplatePropertyInfo.CanWrite.Should().BeFalse();
            uriTemplatePropertyInfo.PropertyType.Should().Be(typeof(float));
        }
    }
}
