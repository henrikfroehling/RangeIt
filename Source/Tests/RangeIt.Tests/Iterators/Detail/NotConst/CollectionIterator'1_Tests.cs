namespace RangeIt.Tests.Iterators.Detail.NotConst
{
    using FluentAssertions;
    using RangeIt.Iterators;
    using System.Collections.ObjectModel;
    using Xunit;

    [Collection("CollectionIterator<T>.Tests")]
    public class CollectionIterator_1_Tests
    {
        [Fact]
        public void Test_CollectionIterator_1_Begin_Ctor_WithEmptyCollection()
        {
            var collection = new Collection<int>();
            var it = collection.Begin();

            it.Should().NotBeNull();
            it.IsEndIterator.Should().BeFalse();
            it.Index.Should().Be(-1);
            it.Current.Should().Be(0);
        }

        [Fact]
        public void Test_CollectionIterator_1_End_Ctor_WithEmptyCollection()
        {
            var collection = new Collection<int>();
            var it = collection.End();

            it.Should().NotBeNull();
            it.IsEndIterator.Should().BeTrue();
            it.Index.Should().Be(-1);
            it.Current.Should().Be(0);
        }

        [Fact]
        public void Test_CollectionIterator_1_Begin_Iteration_WithEmptyCollection()
        {
            var collection = new Collection<int>();
            var it = collection.Begin();

            it.Next().Should().BeFalse();
            it.Index.Should().Be(-1);
            it.Current.Should().Be(0);

            it.Previous().Should().BeFalse();
            it.Index.Should().Be(-1);
            it.Current.Should().Be(0);
        }

        [Fact]
        public void Test_CollectionIterator_1_End_Iteration_WithEmptyCollection()
        {
            var collection = new Collection<int>();
            var it = collection.End();

            it.Next().Should().BeFalse();
            it.Index.Should().Be(-1);
            it.Current.Should().Be(0);

            it.Previous().Should().BeFalse();
            it.Index.Should().Be(-1);
            it.Current.Should().Be(0);
        }

        [Fact]
        public void Test_CollectionIterator_1_Begin_Ctor_WithNotEmptyCollection()
        {
            var collection = new Collection<int> { 1, 2, 3, 4, 5 };
            var it = collection.Begin();

            it.Should().NotBeNull();
            it.IsEndIterator.Should().BeFalse();
            it.Index.Should().Be(-1);
            it.Current.Should().Be(0);
        }

        [Fact]
        public void Test_CollectionIterator_1_End_Ctor_WithNotEmptyCollection()
        {
            var collection = new Collection<int> { 1, 2, 3, 4, 5 };
            var it = collection.End();

            it.Should().NotBeNull();
            it.IsEndIterator.Should().BeTrue();
            it.Index.Should().Be(-1);
            it.Current.Should().Be(0);
        }

        [Fact]
        public void Test_CollectionIterator_1_Begin_Iteration_WithNotEmptyCollection()
        {
            var collection = new Collection<int> { 1, 2, 3, 4, 5 };
            var it = collection.Begin();

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
            it.Index.Should().Be(collection.Count);
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
        public void Test_CollectionIterator_1_End_Iteration_WithNotEmptyCollection()
        {
            var collection = new Collection<int> { 1, 2, 3, 4, 5 };
            var it = collection.End();

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
            it.Index.Should().Be(collection.Count);
            it.Current.Should().Be(0);
        }

        [Fact]
        public void Test_CollectionIterator_1_Begin_Assignment()
        {
            var collection = new Collection<string> { "a", "b", "c", "d", "e" };
            var it = collection.Begin();

            for (int i = 0; i < 3; ++i)
                it.Next();

            it.IsEndIterator.Should().BeFalse();
            it.Index.Should().Be(2);
            it.Current.Should().NotBeNull().And.Be("c");

            it.Current = "g";
            it.IsEndIterator.Should().BeFalse();
            it.Index.Should().Be(2);
            collection.Should().ContainInOrder(new string[] { "a", "b", "g", "d", "e" });
        }

        [Fact]
        public void Test_CollectionIterator_1_End_Assignment()
        {
            var collection = new Collection<string> { "a", "b", "c", "d", "e" };
            var it = collection.End();

            it.IsEndIterator.Should().BeTrue();
            it.Index.Should().Be(-1);
            it.Current.Should().BeNull();

            it.Current = "g";
            it.IsEndIterator.Should().BeTrue();
            it.Index.Should().Be(-1);
            collection.Should().ContainInOrder(new string[] { "a", "b", "c", "d", "e" });
        }

        [Fact]
        public void Test_CollectionIterator_1_Begin_Assignment_IndexOutOfBound()
        {
            var collection = new Collection<string> { "a", "b", "c", "d", "e" };
            var it = collection.Begin();

            it.IsEndIterator.Should().BeFalse();
            it.Index.Should().Be(-1);
            it.Current.Should().BeNull();

            it.Current = "g";
            it.IsEndIterator.Should().BeFalse();
            it.Index.Should().Be(-1);
            collection.Should().ContainInOrder(new string[] { "a", "b", "c", "d", "e" });
        }

        [Fact]
        public void Test_CollectionIterator_1_Begin_IsValid()
        {
            var collection = new Collection<string> { "a", "b", "c", "d", "e" };
            var it = collection.Begin();

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
        public void Test_CollectionIterator_1_End_IsValid()
        {
            var collection = new Collection<string> { "a", "b", "c", "d", "e" };
            var it = collection.End();

            it.IsEndIterator.Should().BeTrue();
            it.Index.Should().Be(-1);
            it.IsValid.Should().BeFalse();
        }
    }
}
