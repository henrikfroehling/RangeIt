namespace RangeIt.Tests.Iterators.Interfaces
{
    using FluentAssertions;
    using RangeIt.Iterators.Interfaces;
    using System;
    using System.Reflection;
    using Traits;
    using Xunit;

    [Category("Iterators.Interfaces.IIterable")]
    public class IIterable_Tests
    {
        [Fact]
        public void Test_IIterable_Is_Interface()
        {
            typeof(IIterable).IsInterface.Should().BeTrue();
        }

        [Fact]
        public void Test_IIterable_Has_Index_Property()
        {
            PropertyInfo uriTemplatePropertyInfo = Array.Find(typeof(IIterable).GetProperties(), p => p.Name == "Index");

            uriTemplatePropertyInfo.CanRead.Should().BeTrue();
            uriTemplatePropertyInfo.CanWrite.Should().BeFalse();
            uriTemplatePropertyInfo.PropertyType.Should().Be(typeof(int));
        }

        [Fact]
        public void Test_IIterable_Has_IsEndIterator_Property()
        {
            PropertyInfo uriTemplatePropertyInfo = Array.Find(typeof(IIterable).GetProperties(), p => p.Name == "IsEndIterator");

            uriTemplatePropertyInfo.CanRead.Should().BeTrue();
            uriTemplatePropertyInfo.CanWrite.Should().BeFalse();
            uriTemplatePropertyInfo.PropertyType.Should().Be(typeof(bool));
        }

        [Fact]
        public void Test_IIterable_Has_IsValid_Property()
        {
            PropertyInfo uriTemplatePropertyInfo = Array.Find(typeof(IIterable).GetProperties(), p => p.Name == "IsValid");

            uriTemplatePropertyInfo.CanRead.Should().BeTrue();
            uriTemplatePropertyInfo.CanWrite.Should().BeFalse();
            uriTemplatePropertyInfo.PropertyType.Should().Be(typeof(bool));
        }

        [Fact]
        public void Test_IIterable_Has_Previous_Method()
        {
            MethodInfo methodInfo = Array.Find(typeof(IIterable).GetMethods(), m => m.Name == "Previous");

            methodInfo.ReturnType.Should().Be(typeof(bool));
            methodInfo.GetParameters().Should().BeEmpty();
        }

        [Fact]
        public void Test_IIterable_Has_Next_Method()
        {
            MethodInfo methodInfo = Array.Find(typeof(IIterable).GetMethods(), m => m.Name == "Next");

            methodInfo.ReturnType.Should().Be(typeof(bool));
            methodInfo.GetParameters().Should().BeEmpty();
        }
    }
}
