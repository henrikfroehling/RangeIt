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

    [Category("Iterators.Iterator<T, U>")]
    public class Iterator_2_Tests
    {
        [Fact]
        public void Test_Iterator_2_IsNot_Abstract()
        {
            typeof(Iterator<,>).IsAbstract.Should().BeFalse();
        }

        [Fact]
        public void Test_Iterator_2_Is_Sealed()
        {
            typeof(Iterator<,>).IsSealed.Should().BeTrue();
        }

        [Fact]
        public void Test_Iterator_2_Is_Generic()
        {
            typeof(Iterator<,>).ContainsGenericParameters.Should().BeTrue();
            typeof(Iterator<int, float>).GenericTypeArguments.Should().NotBeEmpty().And.HaveCount(2);
        }

        [Fact]
        public void Test_Iterator_2_Implements_IIterator_2_Interface()
        {
            typeof(Iterator<int, float>).GetInterfaces().Should().Contain(typeof(IIterator<int, float>));
        }

        [Fact]
        public void Test_Iterator_2_Implements_IIterable_Interface()
        {
            typeof(Iterator<int, float>).GetInterfaces().Should().Contain(typeof(IIterable));
        }

        [Fact]
        public void Test_Iterator_2_Implements_IEnumerable_Interface()
        {
            typeof(Iterator<int, float>).GetInterfaces().Should().Contain(typeof(IEnumerable<KeyValuePair<int, float>>));
        }

        [Fact]
        public void Test_Iterator_2_Has_IteratorHelper_Field()
        {
            FieldInfo iteratorHelperFieldInfo = Array.Find(typeof(Iterator<int, float>)
                .GetFields(BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance), f => f.Name == "_iteratorAdapter");

            iteratorHelperFieldInfo.IsPrivate.Should().BeTrue();
            iteratorHelperFieldInfo.FieldType.Should().Be(typeof(IIteratorAdapter<int, float>));
        }
    }
}
