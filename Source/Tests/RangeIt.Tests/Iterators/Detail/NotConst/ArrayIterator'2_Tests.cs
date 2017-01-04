namespace RangeIt.Tests.Iterators.Detail.NotConst
{
    using FluentAssertions;
    using RangeIt.Iterators;
    using System.Collections.Generic;
    using System.Linq;
    using Xunit;

    [Collection("ArrayIterator<T, U>.Tests")]
    public class ArrayIterator_2_Tests
    {
        [Fact]
        public void Test_ArrayIteratorr_2_Begin_Ctor_WithEmptyList()
        {
            var array = new KeyValuePair<string, int>[0];
            var it = array.Begin();

            it.Should().NotBeNull();
            it.IsEndIterator.Should().BeFalse();
            it.Index.Should().Be(-1);
            it.Current.Should().NotBeNull();
            it.Key.Should().BeNull();
            it.Value.Should().Be(0);
        }

        [Fact]
        public void Test_ArrayIterator_2_End_Ctor_WithEmptyList()
        {
            var array = new KeyValuePair<string, int>[0];
            var it = array.End();

            it.Should().NotBeNull();
            it.IsEndIterator.Should().BeTrue();
            it.Index.Should().Be(-1);
            it.Current.Should().NotBeNull();
            it.Key.Should().BeNull();
            it.Value.Should().Be(0);
        }

        [Fact]
        public void Test_ArrayIterator_2_Begin_Iteration_WithEmptyList()
        {
            var array = new KeyValuePair<string, int>[0];
            var it = array.Begin();

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
        public void Test_ArrayIterator_2_End_Iteration_WithEmptyList()
        {
            var array = new KeyValuePair<string, int>[0];
            var it = array.End();

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
        public void Test_ArrayIterator_2_Begin_Ctor_WithNotEmptyList()
        {
            var array = new KeyValuePair<string, int>[]
            {
                new KeyValuePair<string, int>("one", 1),
                new KeyValuePair<string, int>("two", 2),
                new KeyValuePair<string, int>("three", 3),
                new KeyValuePair<string, int>("four", 4),
                new KeyValuePair<string, int>("five", 5)
            };

            var it = array.Begin();

            it.Should().NotBeNull();
            it.IsEndIterator.Should().BeFalse();
            it.Index.Should().Be(-1);
            it.Current.Should().NotBeNull();
            it.Key.Should().BeNull();
            it.Value.Should().Be(0);
        }

        [Fact]
        public void Test_ArrayIterator_2_End_Ctor_WithNotEmptyList()
        {
            var array = new KeyValuePair<string, int>[]
            {
                new KeyValuePair<string, int>("one", 1),
                new KeyValuePair<string, int>("two", 2),
                new KeyValuePair<string, int>("three", 3),
                new KeyValuePair<string, int>("four", 4),
                new KeyValuePair<string, int>("five", 5)
            };

            var it = array.End();

            it.Should().NotBeNull();
            it.IsEndIterator.Should().BeTrue();
            it.Index.Should().Be(-1);
            it.Current.Should().NotBeNull();
            it.Key.Should().BeNull();
            it.Value.Should().Be(0);
        }

        [Fact]
        public void Test_ArrayIterator_2_Begin_Iteration_WithNotEmptyList()
        {
            var array = new KeyValuePair<string, int>[]
            {
                new KeyValuePair<string, int>("one", 1),
                new KeyValuePair<string, int>("two", 2),
                new KeyValuePair<string, int>("three", 3),
                new KeyValuePair<string, int>("four", 4),
                new KeyValuePair<string, int>("five", 5)
            };

            var it = array.Begin();

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
        public void Test_ArrayIterator_2_End_Iteration_WithNotEmptyList()
        {
            var array = new KeyValuePair<string, int>[]
            {
                new KeyValuePair<string, int>("one", 1),
                new KeyValuePair<string, int>("two", 2),
                new KeyValuePair<string, int>("three", 3),
                new KeyValuePair<string, int>("four", 4),
                new KeyValuePair<string, int>("five", 5)
            };

            var it = array.End();

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
        public void Test_ArrayIterator_2_Begin_Assignment()
        {
            var array = new KeyValuePair<string, int>[]
            {
                new KeyValuePair<string, int>("one", 1),
                new KeyValuePair<string, int>("two", 2),
                new KeyValuePair<string, int>("three", 3),
                new KeyValuePair<string, int>("four", 4),
                new KeyValuePair<string, int>("five", 5)
            };

            var expectedArray = new KeyValuePair<string, int>[]
            {
                new KeyValuePair<string, int>("one", 1),
                new KeyValuePair<string, int>("two", 2),
                new KeyValuePair<string, int>("seven", 7),
                new KeyValuePair<string, int>("four", 4),
                new KeyValuePair<string, int>("five", 5)
            };

            var it = array.Begin();

            for (int i = 0; i < 3; ++i)
                it.Next();

            it.IsEndIterator.Should().BeFalse();
            it.Index.Should().Be(2);
            it.Current.Should().NotBeNull();
            it.Key.Should().NotBeNull().And.Be("three");
            it.Value.Should().Be(3);

            it.Current = new KeyValuePair<string, int>("seven", 7);
            it.IsEndIterator.Should().BeFalse();
            it.Index.Should().Be(2);
            array.Should().ContainInOrder(expectedArray);
        }

        [Fact]
        public void Test_ArrayIterator_2_End_Assignment()
        {
            var array = new KeyValuePair<string, int>[]
            {
                new KeyValuePair<string, int>("one", 1),
                new KeyValuePair<string, int>("two", 2),
                new KeyValuePair<string, int>("three", 3),
                new KeyValuePair<string, int>("four", 4),
                new KeyValuePair<string, int>("five", 5)
            };

            var expectedArray = new KeyValuePair<string, int>[]
            {
                new KeyValuePair<string, int>("one", 1),
                new KeyValuePair<string, int>("two", 2),
                new KeyValuePair<string, int>("three", 3),
                new KeyValuePair<string, int>("four", 4),
                new KeyValuePair<string, int>("five", 5)
            };

            var it = array.End();

            it.IsEndIterator.Should().BeTrue();
            it.Index.Should().Be(-1);
            it.Current.Should().NotBeNull();
            it.Key.Should().BeNull();
            it.Value.Should().Be(0);

            it.Current = new KeyValuePair<string, int>("seven", 7);
            it.IsEndIterator.Should().BeTrue();
            it.Index.Should().Be(-1);
            array.Should().ContainInOrder(expectedArray);
        }

        [Fact]
        public void Test_ArrayIterator_2_Begin_Assignment_IndexOutOfBound()
        {
            var array = new KeyValuePair<string, int>[]
            {
                new KeyValuePair<string, int>("one", 1),
                new KeyValuePair<string, int>("two", 2),
                new KeyValuePair<string, int>("three", 3),
                new KeyValuePair<string, int>("four", 4),
                new KeyValuePair<string, int>("five", 5)
            };

            var expectedArray = new KeyValuePair<string, int>[]
            {
                new KeyValuePair<string, int>("one", 1),
                new KeyValuePair<string, int>("two", 2),
                new KeyValuePair<string, int>("three", 3),
                new KeyValuePair<string, int>("four", 4),
                new KeyValuePair<string, int>("five", 5)
            };

            var it = array.Begin();

            it.IsEndIterator.Should().BeFalse();
            it.Index.Should().Be(-1);
            it.Current.Should().NotBeNull();
            it.Key.Should().BeNull();
            it.Value.Should().Be(0);

            it.Current = new KeyValuePair<string, int>("seven", 7);
            it.IsEndIterator.Should().BeFalse();
            it.Index.Should().Be(-1);
            array.Should().ContainInOrder(expectedArray);
        }

        [Fact]
        public void Test_ArrayIterator_2_Begin_IsValid()
        {
            var array = new KeyValuePair<string, int>[]
            {
                new KeyValuePair<string, int>("one", 1),
                new KeyValuePair<string, int>("two", 2),
                new KeyValuePair<string, int>("three", 3),
                new KeyValuePair<string, int>("four", 4),
                new KeyValuePair<string, int>("five", 5)
            };

            var it = array.Begin();

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
        public void Test_ArrayIterator_2_End_IsValid()
        {
            var array = new KeyValuePair<string, int>[]
            {
                new KeyValuePair<string, int>("one", 1),
                new KeyValuePair<string, int>("two", 2),
                new KeyValuePair<string, int>("three", 3),
                new KeyValuePair<string, int>("four", 4),
                new KeyValuePair<string, int>("five", 5)
            };

            var it = array.End();

            it.IsEndIterator.Should().BeTrue();
            it.Index.Should().Be(-1);
            it.IsValid.Should().BeFalse();
        }
    }
}
