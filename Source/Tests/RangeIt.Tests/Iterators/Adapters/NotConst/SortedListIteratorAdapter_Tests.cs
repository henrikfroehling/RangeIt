namespace RangeIt.Tests.Iterators.Adapters.NotConst
{
    using FluentAssertions;
    using RangeIt.Iterators;
    using System.Collections;
    using Xunit;

    [Collection("SortedListIteratorAdapter.Tests")]
    public class SortedListIteratorAdapter_Tests
    {
        [Fact]
        public void Test_SortedListIteratorAdapter_Begin_Ctor_WithEmptySortedList()
        {
            var sortedList = new SortedList();
            var it = sortedList.Begin();

            it.Should().NotBeNull();
            it.IsEndIterator.Should().BeFalse();
            it.Index.Should().Be(-1);
            it.Current.Should().BeNull();
        }

        [Fact]
        public void Test_SortedListIteratorAdapter_End_Ctor_WithEmptySortedList()
        {
            var sortedList = new SortedList();
            var it = sortedList.End();

            it.Should().NotBeNull();
            it.IsEndIterator.Should().BeTrue();
            it.Index.Should().Be(-1);
            it.Current.Should().BeNull();
        }

        [Fact]
        public void Test_SortedListIteratorAdapter_Begin_Iteration_WithEmptySortedList()
        {
            var sortedList = new SortedList();
            var it = sortedList.Begin();

            it.Next().Should().BeFalse();
            it.Index.Should().Be(-1);
            it.Current.Should().BeNull();

            it.Previous().Should().BeFalse();
            it.Index.Should().Be(-1);
            it.Current.Should().BeNull();
        }

        [Fact]
        public void Test_SortedListIteratorAdapter_End_Iteration_WithEmptySortedList()
        {
            var sortedList = new SortedList();
            var it = sortedList.End();

            it.Next().Should().BeFalse();
            it.Index.Should().Be(-1);
            it.Current.Should().BeNull();

            it.Previous().Should().BeFalse();
            it.Index.Should().Be(-1);
            it.Current.Should().BeNull();
        }

        [Fact]
        public void Test_SortedListIteratorAdapter_Begin_Ctor_WithNotEmptySortedList()
        {
            var sortedList = new SortedList();
            sortedList.Add(1, 1);
            sortedList.Add(2, 2);
            sortedList.Add(3, 3);
            sortedList.Add(4, 4);
            sortedList.Add(5, 5);

            var it = sortedList.Begin();

            it.Should().NotBeNull();
            it.IsEndIterator.Should().BeFalse();
            it.Index.Should().Be(-1);
            it.Current.Should().BeNull();
        }

        [Fact]
        public void Test_SortedListIteratorAdapter_End_Ctor_WithNotEmptySortedList()
        {
            var sortedList = new SortedList();
            sortedList.Add(1, 1);
            sortedList.Add(2, 2);
            sortedList.Add(3, 3);
            sortedList.Add(4, 4);
            sortedList.Add(5, 5);

            var it = sortedList.End();

            it.Should().NotBeNull();
            it.IsEndIterator.Should().BeTrue();
            it.Index.Should().Be(-1);
            it.Current.Should().BeNull();
        }

        [Fact]
        public void Test_SortedListIteratorAdapter_Begin_Iteration_WithNotEmptySortedList()
        {
            var sortedList = new SortedList();
            sortedList.Add(1, 1);
            sortedList.Add(2, 2);
            sortedList.Add(3, 3);
            sortedList.Add(4, 4);
            sortedList.Add(5, 5);

            var it = sortedList.Begin();

            // 1. iteration
            it.Next().Should().BeTrue();
            it.Index.Should().Be(0);
            it.Current.Should().Be(1);

            // 1. back iteration
            it.Previous().Should().BeFalse();
            it.Index.Should().Be(-1);
            it.Current.Should().BeNull();

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
            it.Index.Should().Be(sortedList.Count);
            it.Current.Should().BeNull();

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
            it.Current.Should().BeNull();
        }

        [Fact]
        public void Test_SortedListIteratorAdapter_End_Iteration_WithNotEmptySortedList()
        {
            var sortedList = new SortedList();
            sortedList.Add(1, 1);
            sortedList.Add(2, 2);
            sortedList.Add(3, 3);
            sortedList.Add(4, 4);
            sortedList.Add(5, 5);

            var it = sortedList.End();

            // 1. iteration
            it.Next().Should().BeFalse();
            it.Index.Should().Be(-1);
            it.Current.Should().BeNull();

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
            it.Current.Should().BeNull();

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
            it.Index.Should().Be(sortedList.Count);
            it.Current.Should().BeNull();
        }

        [Fact]
        public void Test_SortedListIteratorAdapter_Begin_Assignment()
        {
            var sortedList = new SortedList();
            sortedList.Add("a", "a");
            sortedList.Add("b", "b");
            sortedList.Add("c", "c");
            sortedList.Add("d", "d");
            sortedList.Add("e", "e");

            var expectedSortedList = new SortedList();
            expectedSortedList.Add("a", "a");
            expectedSortedList.Add("b", "b");
            expectedSortedList.Add("c", "g");
            expectedSortedList.Add("d", "d");
            expectedSortedList.Add("e", "e");

            var it = sortedList.Begin();

            for (int i = 0; i < 3; ++i)
                it.Next();

            it.IsEndIterator.Should().BeFalse();
            it.Index.Should().Be(2);
            it.Current.Should().NotBeNull().And.Be("c");

            it.Current = "g";
            it.IsEndIterator.Should().BeFalse();
            it.Index.Should().Be(2);
            sortedList.Should().Contain(expectedSortedList);
        }

        [Fact]
        public void Test_SortedListIteratorAdapter_End_Assignment()
        {
            var sortedList = new SortedList();
            sortedList.Add("a", "a");
            sortedList.Add("b", "b");
            sortedList.Add("c", "c");
            sortedList.Add("d", "d");
            sortedList.Add("e", "e");

            var expectedSortedList = new SortedList();
            expectedSortedList.Add("a", "a");
            expectedSortedList.Add("b", "b");
            expectedSortedList.Add("c", "c");
            expectedSortedList.Add("d", "d");
            expectedSortedList.Add("e", "e");

            var it = sortedList.End();

            it.IsEndIterator.Should().BeTrue();
            it.Index.Should().Be(-1);
            it.Current.Should().BeNull();

            it.Current = "g";
            it.IsEndIterator.Should().BeTrue();
            it.Index.Should().Be(-1);
            sortedList.Should().Contain(expectedSortedList);
        }

        [Fact]
        public void Test_SortedListIteratorAdapter_Begin_Assignment_IndexOutOfBound()
        {
            var sortedList = new SortedList();
            sortedList.Add("a", "a");
            sortedList.Add("b", "b");
            sortedList.Add("c", "c");
            sortedList.Add("d", "d");
            sortedList.Add("e", "e");

            var expectedSortedList = new SortedList();
            expectedSortedList.Add("a", "a");
            expectedSortedList.Add("b", "b");
            expectedSortedList.Add("c", "c");
            expectedSortedList.Add("d", "d");
            expectedSortedList.Add("e", "e");

            var it = sortedList.Begin();

            it.IsEndIterator.Should().BeFalse();
            it.Index.Should().Be(-1);
            it.Current.Should().BeNull();

            it.Current = "g";
            it.IsEndIterator.Should().BeFalse();
            it.Index.Should().Be(-1);
            sortedList.Should().Contain(expectedSortedList);
        }

        [Fact]
        public void Test_SortedListIteratorAdapter_Begin_IsValid()
        {
            var sortedList = new SortedList();
            sortedList.Add("a", "a");
            sortedList.Add("b", "b");
            sortedList.Add("c", "c");
            sortedList.Add("d", "d");
            sortedList.Add("e", "e");

            var it = sortedList.Begin();

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
        public void Test_SortedListIteratorAdapter_End_IsValid()
        {
            var sortedList = new SortedList();
            sortedList.Add("a", "a");
            sortedList.Add("b", "b");
            sortedList.Add("c", "c");
            sortedList.Add("d", "d");
            sortedList.Add("e", "e");

            var it = sortedList.End();

            it.IsEndIterator.Should().BeTrue();
            it.Index.Should().Be(-1);
            it.IsValid.Should().BeFalse();
        }
    }
}
