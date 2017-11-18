namespace RangeIt.Tests.Iterators.Interfaces
{
    using FluentAssertions;
    using RangeIt.Iterators.Interfaces;
    using System;
    using System.Reflection;
    using Traits;
    using Xunit;

    [Category("Iterators.Interfaces.IIterator<T>")]
    public class IIterator_1_Tests
    {
        [Fact]
        public void Test_IIterator_1_Is_Interface()
        {
            typeof(IIterator<>).IsInterface.Should().BeTrue();
        }

        [Fact]
        public void Test_IIterator_1_Is_Generic()
        {
            typeof(IIterator<>).ContainsGenericParameters.Should().BeTrue();
            typeof(IIterator<int>).GenericTypeArguments.Should().NotBeEmpty().And.HaveCount(1);
        }

        [Fact]
        public void Test_IIterator_1_Has_Current_Property()
        {
            PropertyInfo uriTemplatePropertyInfo = Array.Find(typeof(IIterator<int>).GetProperties(), p => p.Name == "Current");

            uriTemplatePropertyInfo.CanRead.Should().BeTrue();
            uriTemplatePropertyInfo.CanWrite.Should().BeTrue();
            uriTemplatePropertyInfo.PropertyType.Should().Be(typeof(int));
        }
    }
}
