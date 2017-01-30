namespace RangeIt.Tests.Iterators.Adapters.Const
{
    using FluentAssertions;
    using RangeIt.Iterators;
    using System.Collections.Generic;
    using System.Linq;
    using Traits;
    using Xunit;

    [Category("Iterators.Adapters.Const.ArrayConstIteratorAdapter<T, U>")]
    public class ArrayConstIteratorAdapter_2_Tests
    {
        [Fact]
        public void Test_ArrayConstIteratorAdapter_2_Begin_Ctor_WithEmptyArray()
        {
            var array = new KeyValuePair<string, int>[0];
            var it = array.ConstBegin();

            it.Should().NotBeNull();
            it.IsEndIterator.Should().BeFalse();
            it.Index.Should().Be(-1);
            it.Current.Should().NotBeNull();
            it.Key.Should().BeNull();
            it.Value.Should().Be(0);
        }

        [Fact]
        public void Test_ArrayConstIteratorAdapter_2_End_Ctor_WithEmptyArray()
        {
            var array = new KeyValuePair<string, int>[0];
            var it = array.ConstEnd();

            it.Should().NotBeNull();
            it.IsEndIterator.Should().BeTrue();
            it.Index.Should().Be(-1);
            it.Current.Should().NotBeNull();
            it.Key.Should().BeNull();
            it.Value.Should().Be(0);
        }

        [Fact]
        public void Test_ArrayConstIteratorAdapter_2_Begin_Iteration_WithEmptyArray()
        {
            var array = new KeyValuePair<string, int>[0];
            var it = array.ConstBegin();

            it.Next().Should().BeFalse();
            it.Index.Should().Be(-1);
            it.Current.Should().NotBeNull();
            it.Key.Should().BeNull();
            it.Value.Should().Be(0);

            it.Previous().Should().BeFalse();
            it.Index.Should().Be(-1);
            it.Current.Should().NotBeNull();
            it.Key.Should().BeNull();
            it.Value.Should().Be(0);
        }

        [Fact]
        public void Test_ArrayConstIteratorAdapter_2_End_Iteration_WithEmptyArray()
        {
            var array = new KeyValuePair<string, int>[0];
            var it = array.ConstEnd();

            it.Next().Should().BeFalse();
            it.Index.Should().Be(-1);
            it.Current.Should().NotBeNull();
            it.Key.Should().BeNull();
            it.Value.Should().Be(0);

            it.Previous().Should().BeFalse();
            it.Index.Should().Be(-1);
            it.Current.Should().NotBeNull();
            it.Key.Should().BeNull();
            it.Value.Should().Be(0);
        }

        [Fact]
        public void Test_ArrayConstIteratorAdapter_2_Begin_Ctor_WithNotEmptyArray()
        {
            var array = new KeyValuePair<string, int>[]
            {
                new KeyValuePair<string, int>("one", 1),
                new KeyValuePair<string, int>("two", 2),
                new KeyValuePair<string, int>("three", 3),
                new KeyValuePair<string, int>("four", 4),
                new KeyValuePair<string, int>("five", 5)
            };

            var it = array.ConstBegin();

            it.Should().NotBeNull();
            it.IsEndIterator.Should().BeFalse();
            it.Index.Should().Be(-1);
            it.Current.Should().NotBeNull();
            it.Key.Should().BeNull();
            it.Value.Should().Be(0);
        }

        [Fact]
        public void Test_ArrayConstIteratorAdapter_2_End_Ctor_WithNotEmptyArray()
        {
            var array = new KeyValuePair<string, int>[]
            {
                new KeyValuePair<string, int>("one", 1),
                new KeyValuePair<string, int>("two", 2),
                new KeyValuePair<string, int>("three", 3),
                new KeyValuePair<string, int>("four", 4),
                new KeyValuePair<string, int>("five", 5)
            };

            var it = array.ConstEnd();

            it.Should().NotBeNull();
            it.IsEndIterator.Should().BeTrue();
            it.Index.Should().Be(-1);
            it.Current.Should().NotBeNull();
            it.Key.Should().BeNull();
            it.Value.Should().Be(0);
        }

        [Fact]
        public void Test_ArrayConstIteratorAdapter_2_Begin_Iteration_WithNotEmptyArray()
        {
            var array = new KeyValuePair<string, int>[]
            {
                new KeyValuePair<string, int>("one", 1),
                new KeyValuePair<string, int>("two", 2),
                new KeyValuePair<string, int>("three", 3),
                new KeyValuePair<string, int>("four", 4),
                new KeyValuePair<string, int>("five", 5)
            };

            var it = array.ConstBegin();

            // 1. iteration
            it.Next().Should().BeTrue();
            it.Index.Should().Be(0);
            it.Current.Should().NotBeNull();
            it.Key.Should().NotBeNull().And.Be("one");
            it.Value.Should().Be(1);

            // 1. back iteration
            it.Previous().Should().BeFalse();
            it.Index.Should().Be(-1);
            it.Current.Should().NotBeNull();
            it.Key.Should().BeNull();
            it.Value.Should().Be(0);

            // 1. iteration
            it.Next().Should().BeTrue();
            it.Index.Should().Be(0);
            it.Current.Should().NotBeNull();
            it.Key.Should().NotBeNull().And.Be("one");
            it.Value.Should().Be(1);

            // 2. iteration
            it.Next().Should().BeTrue();
            it.Index.Should().Be(1);
            it.Current.Should().NotBeNull();
            it.Key.Should().NotBeNull().And.Be("two");
            it.Value.Should().Be(2);

            // 3. iteration
            it.Next().Should().BeTrue();
            it.Index.Should().Be(2);
            it.Current.Should().NotBeNull();
            it.Key.Should().NotBeNull().And.Be("three");
            it.Value.Should().Be(3);

            // 4. iteration
            it.Next().Should().BeTrue();
            it.Index.Should().Be(3);
            it.Current.Should().NotBeNull();
            it.Key.Should().NotBeNull().And.Be("four");
            it.Value.Should().Be(4);

            // 5. iteration
            it.Next().Should().BeTrue();
            it.Index.Should().Be(4);
            it.Current.Should().NotBeNull();
            it.Key.Should().NotBeNull().And.Be("five");
            it.Value.Should().Be(5);

            // 6. iteration
            it.Next().Should().BeFalse();
            it.IsEndIterator.Should().BeTrue();
            it.Index.Should().Be(array.Count());
            it.Current.Should().NotBeNull();
            it.Key.Should().BeNull();
            it.Value.Should().Be(0);

            // 1. back iteration
            it.Previous().Should().BeTrue();
            it.IsEndIterator.Should().BeFalse();
            it.Index.Should().Be(4);
            it.Current.Should().NotBeNull();
            it.Key.Should().NotBeNull().And.Be("five");
            it.Value.Should().Be(5);

            // 2. back iteration
            it.Previous().Should().BeTrue();
            it.IsEndIterator.Should().BeFalse();
            it.Index.Should().Be(3);
            it.Current.Should().NotBeNull();
            it.Key.Should().NotBeNull().And.Be("four");
            it.Value.Should().Be(4);

            // 3. back iteration
            it.Previous().Should().BeTrue();
            it.IsEndIterator.Should().BeFalse();
            it.Index.Should().Be(2);
            it.Current.Should().NotBeNull();
            it.Key.Should().NotBeNull().And.Be("three");
            it.Value.Should().Be(3);

            // 4. back iteration
            it.Previous().Should().BeTrue();
            it.IsEndIterator.Should().BeFalse();
            it.Index.Should().Be(1);
            it.Current.Should().NotBeNull();
            it.Key.Should().NotBeNull().And.Be("two");
            it.Value.Should().Be(2);

            // 5. back iteration
            it.Previous().Should().BeTrue();
            it.IsEndIterator.Should().BeFalse();
            it.Index.Should().Be(0);
            it.Current.Should().NotBeNull();
            it.Key.Should().NotBeNull().And.Be("one");
            it.Value.Should().Be(1);

            // 6. back iteration
            it.Previous().Should().BeFalse();
            it.IsEndIterator.Should().BeFalse();
            it.Index.Should().Be(-1);
            it.Current.Should().NotBeNull();
            it.Key.Should().BeNull();
            it.Value.Should().Be(0);
        }

        [Fact]
        public void Test_ArrayConstIteratorAdapter_2_End_Iteration_WithNotEmptyArray()
        {
            var array = new KeyValuePair<string, int>[]
            {
                new KeyValuePair<string, int>("one", 1),
                new KeyValuePair<string, int>("two", 2),
                new KeyValuePair<string, int>("three", 3),
                new KeyValuePair<string, int>("four", 4),
                new KeyValuePair<string, int>("five", 5)
            };

            var it = array.ConstEnd();

            // 1. iteration
            it.Next().Should().BeFalse();
            it.Index.Should().Be(-1);
            it.Current.Should().NotBeNull();
            it.Key.Should().BeNull();
            it.Value.Should().Be(0);

            // 1. back iteration
            it.Previous().Should().BeTrue();
            it.IsEndIterator.Should().BeFalse();
            it.Index.Should().Be(4);
            it.Current.Should().NotBeNull();
            it.Key.Should().NotBeNull().And.Be("five");
            it.Value.Should().Be(5);

            // 2. back iteration
            it.Previous().Should().BeTrue();
            it.IsEndIterator.Should().BeFalse();
            it.Index.Should().Be(3);
            it.Current.Should().NotBeNull();
            it.Key.Should().NotBeNull().And.Be("four");
            it.Value.Should().Be(4);

            // 3. back iteration
            it.Previous().Should().BeTrue();
            it.IsEndIterator.Should().BeFalse();
            it.Index.Should().Be(2);
            it.Current.Should().NotBeNull();
            it.Key.Should().NotBeNull().And.Be("three");
            it.Value.Should().Be(3);

            // 4. back iteration
            it.Previous().Should().BeTrue();
            it.IsEndIterator.Should().BeFalse();
            it.Index.Should().Be(1);
            it.Current.Should().NotBeNull();
            it.Key.Should().NotBeNull().And.Be("two");
            it.Value.Should().Be(2);

            // 5. back iteration
            it.Previous().Should().BeTrue();
            it.IsEndIterator.Should().BeFalse();
            it.Index.Should().Be(0);
            it.Current.Should().NotBeNull();
            it.Key.Should().NotBeNull().And.Be("one");
            it.Value.Should().Be(1);

            // 6. back iteration
            it.Previous().Should().BeFalse();
            it.IsEndIterator.Should().BeFalse();
            it.Index.Should().Be(-1);
            it.Current.Should().NotBeNull();
            it.Key.Should().BeNull();
            it.Value.Should().Be(0);

            // 1. iteration
            it.Next().Should().BeTrue();
            it.Index.Should().Be(0);
            it.Current.Should().NotBeNull();
            it.Key.Should().NotBeNull().And.Be("one");
            it.Value.Should().Be(1);

            // 2. iteration
            it.Next().Should().BeTrue();
            it.Index.Should().Be(1);
            it.Current.Should().NotBeNull();
            it.Key.Should().NotBeNull().And.Be("two");
            it.Value.Should().Be(2);

            // 3. iteration
            it.Next().Should().BeTrue();
            it.Index.Should().Be(2);
            it.Current.Should().NotBeNull();
            it.Key.Should().NotBeNull().And.Be("three");
            it.Value.Should().Be(3);

            // 4. iteration
            it.Next().Should().BeTrue();
            it.Index.Should().Be(3);
            it.Current.Should().NotBeNull();
            it.Key.Should().NotBeNull().And.Be("four");
            it.Value.Should().Be(4);

            // 5. iteration
            it.Next().Should().BeTrue();
            it.Index.Should().Be(4);
            it.Current.Should().NotBeNull();
            it.Key.Should().NotBeNull().And.Be("five");
            it.Value.Should().Be(5);

            // 6. iteration
            it.Next().Should().BeFalse();
            it.IsEndIterator.Should().BeTrue();
            it.Index.Should().Be(array.Count());
            it.Current.Should().NotBeNull();
            it.Key.Should().BeNull();
            it.Value.Should().Be(0);
        }

        [Fact]
        public void Test_ArrayConstIteratorAdapter_2_Begin_IsValid()
        {
            var array = new KeyValuePair<string, int>[]
            {
                new KeyValuePair<string, int>("one", 1),
                new KeyValuePair<string, int>("two", 2),
                new KeyValuePair<string, int>("three", 3),
                new KeyValuePair<string, int>("four", 4),
                new KeyValuePair<string, int>("five", 5)
            };

            var it = array.ConstBegin();

            it.IsEndIterator.Should().BeFalse();
            it.Index.Should().Be(-1);
            it.IsValid.Should().BeFalse();

            // 1. iteration
            it.Next().Should().BeTrue();
            it.IsEndIterator.Should().BeFalse();
            it.Index.Should().Be(0);
            it.IsValid.Should().BeTrue();

            // 2. iteration
            it.Next().Should().BeTrue();
            it.IsEndIterator.Should().BeFalse();
            it.Index.Should().Be(1);
            it.IsValid.Should().BeTrue();

            // 3. iteration
            it.Next().Should().BeTrue();
            it.IsEndIterator.Should().BeFalse();
            it.Index.Should().Be(2);
            it.IsValid.Should().BeTrue();

            // 4. iteration
            it.Next().Should().BeTrue();
            it.IsEndIterator.Should().BeFalse();
            it.Index.Should().Be(3);
            it.IsValid.Should().BeTrue();

            // 5. iteration
            it.Next().Should().BeTrue();
            it.IsEndIterator.Should().BeFalse();
            it.Index.Should().Be(4);
            it.IsValid.Should().BeTrue();

            // 6. iteration
            it.Next().Should().BeFalse();
            it.IsEndIterator.Should().BeTrue();
            it.Index.Should().Be(5);
            it.IsValid.Should().BeFalse();
        }

        [Fact]
        public void Test_ArrayConstIteratorAdapter_2_End_IsValid()
        {
            var array = new KeyValuePair<string, int>[]
            {
                new KeyValuePair<string, int>("one", 1),
                new KeyValuePair<string, int>("two", 2),
                new KeyValuePair<string, int>("three", 3),
                new KeyValuePair<string, int>("four", 4),
                new KeyValuePair<string, int>("five", 5)
            };

            var it = array.ConstEnd();

            it.IsEndIterator.Should().BeTrue();
            it.Index.Should().Be(-1);
            it.IsValid.Should().BeFalse();
        }
    }
}
