namespace RangeIt.Tests.Iterators
{
    using FluentAssertions;
    using RangeIt.Iterators;
    using RangeIt.Iterators.Interfaces;
    using RangeIt.Iterators.Interfaces.Adapters;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;
    using Traits;
    using Xunit;

    [Category("Iterators.ConstIterator<T, U>")]
    public class ConstIterator_2_Tests
    {
        [Fact]
        public void Test_ConstIterator_2_IsNot_Abstract()
        {
            typeof(ConstIterator<,>).IsAbstract.Should().BeFalse();
        }

        [Fact]
        public void Test_ConstIterator_2_Is_Sealed()
        {
            typeof(ConstIterator<,>).IsSealed.Should().BeTrue();
        }

        [Fact]
        public void Test_ConstIterator_2_Is_Generic()
        {
            typeof(ConstIterator<,>).ContainsGenericParameters.Should().BeTrue();
            typeof(ConstIterator<int, float>).GenericTypeArguments.Should().NotBeEmpty().And.HaveCount(2);
        }

        [Fact]
        public void Test_ConstIterator_2_Implements_IConstIterator_2_Interface()
        {
            typeof(ConstIterator<int, float>).GetInterfaces().Should().Contain(typeof(IConstIterator<int, float>));
        }

        [Fact]
        public void Test_ConstIterator_2_Implements_IIterable_Interface()
        {
            typeof(ConstIterator<int, float>).GetInterfaces().Should().Contain(typeof(IIterable));
        }

        [Fact]
        public void Test_ConstIterator_2_Implements_IEnumerable_Interface()
        {
            typeof(ConstIterator<int, float>).GetInterfaces().Should().Contain(typeof(IEnumerable<KeyValuePair<int, float>>));
        }

        [Fact]
        public void Test_ConstIterator_2_Has_IteratorHelper_Field()
        {
            var iteratorHelperFieldInfo = typeof(ConstIterator<int, float>)
                .GetFields(BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance)
                .Where(f => f.Name == "_iteratorAdapter")
                .FirstOrDefault();

            iteratorHelperFieldInfo.IsPrivate.Should().BeTrue();
            iteratorHelperFieldInfo.FieldType.Should().Be(typeof(IConstIteratorAdapter<int, float>));
        }
    }
}
