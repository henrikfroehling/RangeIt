namespace RangeIt.Tests.Iterators
{
    using FluentAssertions;
    using RangeIt.Iterators;
    using RangeIt.Iterators.Interfaces;
    using RangeIt.Iterators.Interfaces.Adapters;
    using System;
    using System.Collections.Generic;
    using System.Reflection;
    using Traits;
    using Xunit;

    [Category("Iterators.Iterator<T>")]
    public class Iterator_1_Tests
    {
        [Fact]
        public void Test_Iterator_1_IsNot_Abstract()
        {
            typeof(Iterator<>).IsAbstract.Should().BeFalse();
        }

        [Fact]
        public void Test_Iterator_1_Is_Sealed()
        {
            typeof(Iterator<>).IsSealed.Should().BeTrue();
        }

        [Fact]
        public void Test_Iterator_1_Is_Generic()
        {
            typeof(Iterator<>).ContainsGenericParameters.Should().BeTrue();
            typeof(Iterator<int>).GenericTypeArguments.Should().NotBeEmpty().And.HaveCount(1);
        }

        [Fact]
        public void Test_Iterator_1_Implements_IIterator_1_Interface()
        {
            typeof(Iterator<int>).GetInterfaces().Should().Contain(typeof(IIterator<int>));
        }

        [Fact]
        public void Test_Iterator_1_Implements_IIterable_Interface()
        {
            typeof(Iterator<int>).GetInterfaces().Should().Contain(typeof(IIterable));
        }

        [Fact]
        public void Test_Iterator_1_Implements_IEnumerable_Interface()
        {
            typeof(Iterator<int>).GetInterfaces().Should().Contain(typeof(IEnumerable<int>));
        }

        [Fact]
        public void Test_Iterator_1_Has_IteratorHelper_Field()
        {
            FieldInfo iteratorHelperFieldInfo = Array.Find(typeof(Iterator<int>)
                .GetFields(BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance), f => f.Name == "_iteratorAdapter");

            iteratorHelperFieldInfo.IsPrivate.Should().BeTrue();
            iteratorHelperFieldInfo.FieldType.Should().Be(typeof(IIteratorAdapter<int>));
        }
    }
}
