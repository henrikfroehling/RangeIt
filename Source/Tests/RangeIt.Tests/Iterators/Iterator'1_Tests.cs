namespace RangeIt.Tests.Iterators
{
    using FluentAssertions;
    using RangeIt.Iterators;
    using RangeIt.Iterators.Interfaces;
    using System.Linq;
    using System.Reflection;
    using Xunit;

    [Collection("Iterator<T>.Tests")]
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
        public void Test_Iterator_1_Has_IteratorHelper_Field()
        {
            var iteratorHelperFieldInfo = typeof(Iterator<int>)
                .GetFields(BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance)
                .Where(f => f.Name == "_iteratorHelper")
                .FirstOrDefault();

            iteratorHelperFieldInfo.IsPrivate.Should().BeTrue();
            iteratorHelperFieldInfo.FieldType.Should().Be(typeof(IIterator<int>));
        }
    }
}
