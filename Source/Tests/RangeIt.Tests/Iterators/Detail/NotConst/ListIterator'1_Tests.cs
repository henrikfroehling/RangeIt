namespace RangeIt.Tests.Iterators.Detail.NotConst
{
    using FluentAssertions;
    using RangeIt.Iterators;
    using System.Collections.Generic;
    using Xunit;

    [Collection("ListIterator<T>.Tests")]
    public class ListIterator_1_Tests
    {
        [Fact]
        public void Test_ListIterator_1_Begin_Ctor_WithEmptyIntList()
        {
            var list = new List<int>();
            var it = list.Begin();

            it.Should().NotBeNull();
            it.IsEndIterator.Should().BeFalse();
            it.Index.Should().Be(-1);
            it.Current.Should().Be(0);
        }

        [Fact]
        public void Test_ListIterator_1_Begin_Ctor_WithEmptyObjectList()
        {
            var list = new List<object>();
            var it = list.Begin();

            it.Should().NotBeNull();
            it.IsEndIterator.Should().BeFalse();
            it.Index.Should().Be(-1);
            it.Current.Should().BeNull();
        }

        [Fact]
        public void Test_ListIterator_1_End_Ctor_WithEmptyIntList()
        {
            var list = new List<int>();
            var it = list.End();

            it.Should().NotBeNull();
            it.IsEndIterator.Should().BeTrue();
            it.Index.Should().Be(-1);
            it.Current.Should().Be(0);
        }

        [Fact]
        public void Test_ListIterator_1_End_Ctor_WithEmptyObjectList()
        {
            var list = new List<object>();
            var it = list.End();

            it.Should().NotBeNull();
            it.IsEndIterator.Should().BeTrue();
            it.Index.Should().Be(-1);
            it.Current.Should().BeNull();
        }

        [Fact]
        public void Test_ListIterator_1_Begin_Iteration_WithEmptyIntList()
        {
            var list = new List<int>();
            var it = list.Begin();

            it.Next().Should().BeFalse();
            it.Index.Should().Be(-1);
            it.Current.Should().Be(0);

            it.Previous().Should().BeFalse();
            it.Index.Should().Be(-1);
            it.Current.Should().Be(0);
        }

        [Fact]
        public void Test_ListIterator_1_Begin_Iteration_WithEmptyObjectList()
        {
            var list = new List<object>();
            var it = list.Begin();

            it.Next().Should().BeFalse();
            it.Index.Should().Be(-1);
            it.Current.Should().BeNull();

            it.Previous().Should().BeFalse();
            it.Index.Should().Be(-1);
            it.Current.Should().BeNull();
        }

        [Fact]
        public void Test_ListIterator_1_End_Iteration_WithEmptyIntList()
        {
            var list = new List<int>();
            var it = list.End();

            it.Next().Should().BeFalse();
            it.Index.Should().Be(-1);
            it.Current.Should().Be(0);

            it.Previous().Should().BeFalse();
            it.Index.Should().Be(-1);
            it.Current.Should().Be(0);
        }

        [Fact]
        public void Test_ListIterator_1_End_Iteration_WithEmptyObjectList()
        {
            var list = new List<object>();
            var it = list.End();

            it.Next().Should().BeFalse();
            it.Index.Should().Be(-1);
            it.Current.Should().BeNull();

            it.Previous().Should().BeFalse();
            it.Index.Should().Be(-1);
            it.Current.Should().BeNull();
        }

        [Fact]
        public void Test_ListIterator_1_Begin_Ctor_WithNotEmptyIntList()
        {
            var list = new List<int> { 1, 2, 3, 4, 5 };
            var it = list.Begin();

            it.Should().NotBeNull();
            it.IsEndIterator.Should().BeFalse();
            it.Index.Should().Be(-1);
            it.Current.Should().Be(0);
        }

        [Fact]
        public void Test_ListIterator_1_Begin_Ctor_WithNotEmptyStringList()
        {
            var list = new List<string> { "a", "b", "c", "d", "e" };
            var it = list.Begin();

            it.Should().NotBeNull();
            it.IsEndIterator.Should().BeFalse();
            it.Index.Should().Be(-1);
            it.Current.Should().BeNull();
        }

        [Fact]
        public void Test_ListIterator_1_End_Ctor_WithNotEmptyIntList()
        {
            var list = new List<int> { 1, 2, 3, 4, 5 };
            var it = list.End();

            it.Should().NotBeNull();
            it.IsEndIterator.Should().BeTrue();
            it.Index.Should().Be(-1);
            it.Current.Should().Be(0);
        }

        [Fact]
        public void Test_ListIterator_1_End_Ctor_WithNotEmptyStringList()
        {
            var list = new List<string> { "a", "b", "c", "d", "e" };
            var it = list.End();

            it.Should().NotBeNull();
            it.IsEndIterator.Should().BeTrue();
            it.Index.Should().Be(-1);
            it.Current.Should().BeNull();
        }

        [Fact]
        public void Test_ListIterator_1_Begin_Iteration_WithNotEmptyIntList()
        {
            var list = new List<int> { 1, 2, 3, 4, 5 };
            var it = list.Begin();

            // 1. iteration
            it.Next().Should().BeTrue();
            it.Index.Should().Be(0);
            it.Current.Should().Be(1);

            // 1. back iteration
            it.Previous().Should().BeFalse();
            it.Index.Should().Be(-1);
            it.Current.Should().Be(0);

            // 1. iteration
            it.Next().Should().BeTrue();
            it.Index.Should().Be(0);
            it.Current.Should().Be(1);

            // 2. iteration
            it.Next().Should().BeTrue();
            it.Index.Should().Be(1);
            it.Current.Should().Be(2);

            // 3. iteration
            it.Next().Should().BeTrue();
            it.Index.Should().Be(2);
            it.Current.Should().Be(3);

            // 4. iteration
            it.Next().Should().BeTrue();
            it.Index.Should().Be(3);
            it.Current.Should().Be(4);

            // 5. iteration
            it.Next().Should().BeTrue();
            it.Index.Should().Be(4);
            it.Current.Should().Be(5);

            // 6. iteration
            it.Next().Should().BeFalse();
            it.IsEndIterator.Should().BeTrue();
            it.Index.Should().Be(list.Count);
            it.Current.Should().Be(0);

            // 1. back iteration
            it.Previous().Should().BeTrue();
            it.IsEndIterator.Should().BeFalse();
            it.Index.Should().Be(4);
            it.Current.Should().Be(5);

            // 2. back iteration
            it.Previous().Should().BeTrue();
            it.IsEndIterator.Should().BeFalse();
            it.Index.Should().Be(3);
            it.Current.Should().Be(4);

            // 3. back iteration
            it.Previous().Should().BeTrue();
            it.IsEndIterator.Should().BeFalse();
            it.Index.Should().Be(2);
            it.Current.Should().Be(3);

            // 4. back iteration
            it.Previous().Should().BeTrue();
            it.IsEndIterator.Should().BeFalse();
            it.Index.Should().Be(1);
            it.Current.Should().Be(2);

            // 5. back iteration
            it.Previous().Should().BeTrue();
            it.IsEndIterator.Should().BeFalse();
            it.Index.Should().Be(0);
            it.Current.Should().Be(1);

            // 6. back iteration
            it.Previous().Should().BeFalse();
            it.IsEndIterator.Should().BeFalse();
            it.Index.Should().Be(-1);
            it.Current.Should().Be(0);
        }

        [Fact]
        public void Test_ListIterator_1_Begin_Iteration_WithNotEmptyStringList()
        {
            var list = new List<string> { "a", "b", "c", "d", "e" };
            var it = list.Begin();

            // 1. iteration
            it.Next().Should().BeTrue();
            it.Index.Should().Be(0);
            it.Current.Should().NotBeNull().And.Be("a");

            // 1. back iteration
            it.Previous().Should().BeFalse();
            it.Index.Should().Be(-1);
            it.Current.Should().BeNull();

            // 1. iteration
            it.Next().Should().BeTrue();
            it.Index.Should().Be(0);
            it.Current.Should().NotBeNull().And.Be("a");

            // 2. iteration
            it.Next().Should().BeTrue();
            it.Index.Should().Be(1);
            it.Current.Should().NotBeNull().And.Be("b");

            // 3. iteration
            it.Next().Should().BeTrue();
            it.Index.Should().Be(2);
            it.Current.Should().NotBeNull().And.Be("c");

            // 4. iteration
            it.Next().Should().BeTrue();
            it.Index.Should().Be(3);
            it.Current.Should().NotBeNull().And.Be("d");

            // 5. iteration
            it.Next().Should().BeTrue();
            it.Index.Should().Be(4);
            it.Current.Should().NotBeNull().And.Be("e");

            // 6. iteration
            it.Next().Should().BeFalse();
            it.IsEndIterator.Should().BeTrue();
            it.Index.Should().Be(list.Count);
            it.Current.Should().BeNull();

            // 1. back iteration
            it.Previous().Should().BeTrue();
            it.IsEndIterator.Should().BeFalse();
            it.Index.Should().Be(4);
            it.Current.Should().NotBeNull().And.Be("e");

            // 2. back iteration
            it.Previous().Should().BeTrue();
            it.IsEndIterator.Should().BeFalse();
            it.Index.Should().Be(3);
            it.Current.Should().NotBeNull().And.Be("d");

            // 3. back iteration
            it.Previous().Should().BeTrue();
            it.IsEndIterator.Should().BeFalse();
            it.Index.Should().Be(2);
            it.Current.Should().NotBeNull().And.Be("c");

            // 4. back iteration
            it.Previous().Should().BeTrue();
            it.IsEndIterator.Should().BeFalse();
            it.Index.Should().Be(1);
            it.Current.Should().NotBeNull().And.Be("b");

            // 5. back iteration
            it.Previous().Should().BeTrue();
            it.IsEndIterator.Should().BeFalse();
            it.Index.Should().Be(0);
            it.Current.Should().NotBeNull().And.Be("a");

            // 6. back iteration
            it.Previous().Should().BeFalse();
            it.IsEndIterator.Should().BeFalse();
            it.Index.Should().Be(-1);
            it.Current.Should().BeNull();
        }

        [Fact]
        public void Test_ListIterator_1_End_Iteration_WithNotEmptyIntList()
        {
            var list = new List<int> { 1, 2, 3, 4, 5 };
            var it = list.End();

            // 1. iteration
            it.Next().Should().BeFalse();
            it.Index.Should().Be(-1);
            it.Current.Should().Be(0);

            // 1. back iteration
            it.Previous().Should().BeTrue();
            it.IsEndIterator.Should().BeFalse();
            it.Index.Should().Be(4);
            it.Current.Should().Be(5);

            // 2. back iteration
            it.Previous().Should().BeTrue();
            it.IsEndIterator.Should().BeFalse();
            it.Index.Should().Be(3);
            it.Current.Should().Be(4);

            // 3. back iteration
            it.Previous().Should().BeTrue();
            it.IsEndIterator.Should().BeFalse();
            it.Index.Should().Be(2);
            it.Current.Should().Be(3);

            // 4. back iteration
            it.Previous().Should().BeTrue();
            it.IsEndIterator.Should().BeFalse();
            it.Index.Should().Be(1);
            it.Current.Should().Be(2);

            // 5. back iteration
            it.Previous().Should().BeTrue();
            it.IsEndIterator.Should().BeFalse();
            it.Index.Should().Be(0);
            it.Current.Should().Be(1);

            // 6. back iteration
            it.Previous().Should().BeFalse();
            it.IsEndIterator.Should().BeFalse();
            it.Index.Should().Be(-1);
            it.Current.Should().Be(0);

            // 1. iteration
            it.Next().Should().BeTrue();
            it.Index.Should().Be(0);
            it.Current.Should().Be(1);

            // 2. iteration
            it.Next().Should().BeTrue();
            it.Index.Should().Be(1);
            it.Current.Should().Be(2);

            // 3. iteration
            it.Next().Should().BeTrue();
            it.Index.Should().Be(2);
            it.Current.Should().Be(3);

            // 4. iteration
            it.Next().Should().BeTrue();
            it.Index.Should().Be(3);
            it.Current.Should().Be(4);

            // 5. iteration
            it.Next().Should().BeTrue();
            it.Index.Should().Be(4);
            it.Current.Should().Be(5);

            // 6. iteration
            it.Next().Should().BeFalse();
            it.IsEndIterator.Should().BeTrue();
            it.Index.Should().Be(list.Count);
            it.Current.Should().Be(0);
        }

        [Fact]
        public void Test_ListIterator_1_End_Iteration_WithNotEmptyStringList()
        {
            var list = new List<string> { "a", "b", "c", "d", "e" };
            var it = list.End();

            // 1. iteration
            it.Next().Should().BeFalse();
            it.Index.Should().Be(-1);
            it.Current.Should().BeNull();

            // 1. back iteration
            it.Previous().Should().BeTrue();
            it.IsEndIterator.Should().BeFalse();
            it.Index.Should().Be(4);
            it.Current.Should().NotBeNull().And.Be("e");

            // 2. back iteration
            it.Previous().Should().BeTrue();
            it.IsEndIterator.Should().BeFalse();
            it.Index.Should().Be(3);
            it.Current.Should().NotBeNull().And.Be("d");

            // 3. back iteration
            it.Previous().Should().BeTrue();
            it.IsEndIterator.Should().BeFalse();
            it.Index.Should().Be(2);
            it.Current.Should().NotBeNull().And.Be("c");

            // 4. back iteration
            it.Previous().Should().BeTrue();
            it.IsEndIterator.Should().BeFalse();
            it.Index.Should().Be(1);
            it.Current.Should().NotBeNull().And.Be("b");

            // 5. back iteration
            it.Previous().Should().BeTrue();
            it.IsEndIterator.Should().BeFalse();
            it.Index.Should().Be(0);
            it.Current.Should().NotBeNull().And.Be("a");

            // 6. back iteration
            it.Previous().Should().BeFalse();
            it.IsEndIterator.Should().BeFalse();
            it.Index.Should().Be(-1);
            it.Current.Should().BeNull();

            // 1. iteration
            it.Next().Should().BeTrue();
            it.Index.Should().Be(0);
            it.Current.Should().NotBeNull().And.Be("a");

            // 2. iteration
            it.Next().Should().BeTrue();
            it.Index.Should().Be(1);
            it.Current.Should().NotBeNull().And.Be("b");

            // 3. iteration
            it.Next().Should().BeTrue();
            it.Index.Should().Be(2);
            it.Current.Should().NotBeNull().And.Be("c");

            // 4. iteration
            it.Next().Should().BeTrue();
            it.Index.Should().Be(3);
            it.Current.Should().NotBeNull().And.Be("d");

            // 5. iteration
            it.Next().Should().BeTrue();
            it.Index.Should().Be(4);
            it.Current.Should().NotBeNull().And.Be("e");

            // 6. iteration
            it.Next().Should().BeFalse();
            it.IsEndIterator.Should().BeTrue();
            it.Index.Should().Be(list.Count);
            it.Current.Should().BeNull();
        }

        [Fact]
        public void Test_ListIterator_1_Begin_Assignment()
        {
            var list = new List<string> { "a", "b", "c", "d", "e" };
            var it = list.Begin();

            for (int i = 0; i < 3; ++i)
                it.Next();

            it.IsEndIterator.Should().BeFalse();
            it.Index.Should().Be(2);
            it.Current.Should().NotBeNull().And.Be("c");

            it.Current = "g";
            it.IsEndIterator.Should().BeFalse();
            it.Index.Should().Be(2);
            list.Should().ContainInOrder("a", "b", "g", "d", "e");
        }

        [Fact]
        public void Test_ListIterator_1_End_Assignment()
        {
            var list = new List<string> { "a", "b", "c", "d", "e" };
            var it = list.End();

            it.IsEndIterator.Should().BeTrue();
            it.Index.Should().Be(-1);
            it.Current.Should().BeNull();

            it.Current = "g";
            it.IsEndIterator.Should().BeTrue();
            it.Index.Should().Be(-1);
            list.Should().ContainInOrder("a", "b", "c", "d", "e");
        }

        [Fact]
        public void Test_ListIterator_1_Begin_Assignment_IndexOutOfBound()
        {
            var list = new List<string> { "a", "b", "c", "d", "e" };
            var it = list.Begin();

            it.IsEndIterator.Should().BeFalse();
            it.Index.Should().Be(-1);
            it.Current.Should().BeNull();

            it.Current = "g";
            it.IsEndIterator.Should().BeFalse();
            it.Index.Should().Be(-1);
            list.Should().ContainInOrder("a", "b", "c", "d", "e");
        }

        [Fact]
        public void Test_ListIterator_1_Begin_IsValid()
        {
            var list = new List<string> { "a", "b", "c", "d", "e" };
            var it = list.Begin();

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
        public void Test_ListIterator_1_End_IsValid()
        {
            var list = new List<string> { "a", "b", "c", "d", "e" };
            var it = list.End();

            it.IsEndIterator.Should().BeTrue();
            it.Index.Should().Be(-1);
            it.IsValid.Should().BeFalse();
        }
    }
}
