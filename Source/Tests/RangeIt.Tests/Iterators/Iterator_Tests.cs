namespace RangeIt.Tests.Iterators
{
    using FluentAssertions;
    using RangeIt.Iterators;
    using RangeIt.Iterators.Interfaces;
    using RangeIt.Iterators.Interfaces.Adapters;
    using System.Collections;
    using System.Linq;
    using System.Reflection;
    using Xunit;

    [Collection("Iterator.Tests")]
    public class Iterator_Tests
    {
        [Fact]
        public void Test_Iterator_IsNot_Abstract()
        {
            typeof(Iterator).IsAbstract.Should().BeFalse();
        }

        [Fact]
        public void Test_Iterator_Is_Sealed()
        {
            typeof(Iterator).IsSealed.Should().BeTrue();
        }

        [Fact]
        public void Test_Iterator_Implements_IIterator_Interface()
        {
            typeof(Iterator).GetInterfaces().Should().Contain(typeof(IIterator));
        }

        [Fact]
        public void Test_Iterator_Implements_IIterable_Interface()
        {
            typeof(Iterator).GetInterfaces().Should().Contain(typeof(IIterable));
        }

        [Fact]
        public void Test_Iterator_Implements_IEnumerable_Interface()
        {
            typeof(Iterator).GetInterfaces().Should().Contain(typeof(IEnumerable));
        }

        [Fact]
        public void Test_Iterator_Has_IteratorHelper_Field()
        {
            var iteratorHelperFieldInfo = typeof(Iterator)
                .GetFields(BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance)
                .Where(f => f.Name == "_iteratorAdapter")
                .FirstOrDefault();

            iteratorHelperFieldInfo.IsPrivate.Should().BeTrue();
            iteratorHelperFieldInfo.FieldType.Should().Be(typeof(IIteratorAdapter));
        }
    }
}
