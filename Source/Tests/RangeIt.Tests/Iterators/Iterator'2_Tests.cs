namespace RangeIt.Tests.Iterators
{
    using FluentAssertions;
    using RangeIt.Iterators;
    using RangeIt.Iterators.Interfaces;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;
    using Xunit;

    [Collection("Iterator<T, U>.Tests")]
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
            var iteratorHelperFieldInfo = typeof(Iterator<int, float>)
                .GetFields(BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance)
                .Where(f => f.Name == "_iteratorHelper")
                .FirstOrDefault();

            iteratorHelperFieldInfo.IsPrivate.Should().BeTrue();
            iteratorHelperFieldInfo.FieldType.Should().Be(typeof(IIterator<int, float>));
        }
    }
}
