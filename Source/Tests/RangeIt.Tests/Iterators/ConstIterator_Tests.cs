namespace RangeIt.Tests.Iterators
{
    using FluentAssertions;
    using RangeIt.Iterators;
    using RangeIt.Iterators.Interfaces;
    using System.Linq;
    using System.Reflection;
    using Xunit;

    [Collection("ConstIterator.Tests")]
    public class ConstIterator_Tests
    {
        [Fact]
        public void Test_ConstIterator_IsNot_Abstract()
        {
            typeof(ConstIterator).IsAbstract.Should().BeFalse();
        }

        [Fact]
        public void Test_ConstIterator_Is_Sealed()
        {
            typeof(ConstIterator).IsSealed.Should().BeTrue();
        }

        [Fact]
        public void Test_ConstIterator_Implements_IConstIterator_Interface()
        {
            typeof(ConstIterator).GetInterfaces().Should().Contain(typeof(IConstIterator));
        }

        [Fact]
        public void Test_ConstIterator_Has_IteratorHelper_Field()
        {
            var iteratorHelperFieldInfo = typeof(ConstIterator)
                .GetFields(BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance)
                .Where(f => f.Name == "_iteratorHelper")
                .FirstOrDefault();

            iteratorHelperFieldInfo.IsPrivate.Should().BeTrue();
            iteratorHelperFieldInfo.FieldType.Should().Be(typeof(IConstIterator));
        }
    }
}
