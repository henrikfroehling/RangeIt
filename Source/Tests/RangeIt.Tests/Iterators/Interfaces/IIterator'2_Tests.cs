namespace RangeIt.Tests.Iterators.Interfaces
{
    using FluentAssertions;
    using RangeIt.Iterators.Interfaces;
    using System;
    using System.Collections.Generic;
    using System.Reflection;
    using Traits;
    using Xunit;

    [Category("Iterators.Interfaces.IIterator<T, U>")]
    public class IIterator_2_Tests
    {
        [Fact]
        public void Test_IIterator_2_Is_Interface()
        {
            typeof(IIterator<,>).IsInterface.Should().BeTrue();
        }

        [Fact]
        public void Test_IIterator_2_Is_Generic()
        {
            typeof(IIterator<,>).ContainsGenericParameters.Should().BeTrue();
            typeof(IIterator<int, float>).GenericTypeArguments.Should().NotBeEmpty().And.HaveCount(2);
        }

        [Fact]
        public void Test_IIterator_2_Has_Current_Property()
        {
            PropertyInfo uriTemplatePropertyInfo = Array.Find(typeof(IIterator<int, float>).GetProperties(), p => p.Name == "Current");

            uriTemplatePropertyInfo.CanRead.Should().BeTrue();
            uriTemplatePropertyInfo.CanWrite.Should().BeTrue();
            uriTemplatePropertyInfo.PropertyType.Should().Be(typeof(KeyValuePair<int, float>));
        }

        [Fact]
        public void Test_IIterator_2_Has_Key_Property()
        {
            PropertyInfo uriTemplatePropertyInfo = Array.Find(typeof(IIterator<int, float>).GetProperties(), p => p.Name == "Key");

            uriTemplatePropertyInfo.CanRead.Should().BeTrue();
            uriTemplatePropertyInfo.CanWrite.Should().BeFalse();
            uriTemplatePropertyInfo.PropertyType.Should().Be(typeof(int));
        }

        [Fact]
        public void Test_IIterator_2_Has_Value_Property()
        {
            PropertyInfo uriTemplatePropertyInfo = Array.Find(typeof(IIterator<int, float>).GetProperties(), p => p.Name == "Value");

            uriTemplatePropertyInfo.CanRead.Should().BeTrue();
            uriTemplatePropertyInfo.CanWrite.Should().BeFalse();
            uriTemplatePropertyInfo.PropertyType.Should().Be(typeof(float));
        }
    }
}
