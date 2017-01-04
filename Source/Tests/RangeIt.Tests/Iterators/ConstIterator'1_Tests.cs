namespace RangeIt.Tests.Iterators
{
    using FluentAssertions;
    using RangeIt.Iterators;
    using RangeIt.Iterators.Interfaces;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;
    using Xunit;

    [Collection("ConstIterator<T>.Tests")]
    public class ConstIterator_1_Tests
    {
        [Fact]
        public void Test_ConstIterator_1_IsNot_Abstract()
        {
            typeof(ConstIterator<>).IsAbstract.Should().BeFalse();
        }

        [Fact]
        public void Test_ConstIterator_1_Is_Sealed()
        {
            typeof(ConstIterator<>).IsSealed.Should().BeTrue();
        }

        [Fact]
        public void Test_ConstIterator_1_Is_Generic()
        {
            typeof(ConstIterator<>).ContainsGenericParameters.Should().BeTrue();
            typeof(ConstIterator<int>).GenericTypeArguments.Should().NotBeEmpty().And.HaveCount(1);
        }

        [Fact]
        public void Test_ConstIterator_1_Implements_IConstIterator_1_Interface()
        {
            typeof(ConstIterator<int>).GetInterfaces().Should().Contain(typeof(IConstIterator<int>));
        }

        [Fact]
        public void Test_ConstIterator_1_Implements_IIterable_Interface()
        {
            typeof(ConstIterator<int>).GetInterfaces().Should().Contain(typeof(IIterable));
        }

        [Fact]
        public void Test_ConstIterator_1_Implements_IEnumerable_Interface()
        {
            typeof(ConstIterator<int>).GetInterfaces().Should().Contain(typeof(IEnumerable<int>));
        }

        [Fact]
        public void Test_ConstIterator_1_Has_IteratorHelper_Field()
        {
            var iteratorHelperFieldInfo = typeof(ConstIterator<int>)
                .GetFields(BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance)
                .Where(f => f.Name == "_iteratorHelper")
                .FirstOrDefault();

            iteratorHelperFieldInfo.IsPrivate.Should().BeTrue();
            iteratorHelperFieldInfo.FieldType.Should().Be(typeof(IConstIterator<int>));
        }
    }
}
