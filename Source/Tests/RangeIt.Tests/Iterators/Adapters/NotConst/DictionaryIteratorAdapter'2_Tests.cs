namespace RangeIt.Tests.Iterators.Adapters.NotConst
{
    using FluentAssertions;
    using RangeIt.Iterators;
    using System.Collections.Generic;
    using Traits;
    using Xunit;

    [Category("Iterators.Adapters.NotConst.DictionaryIteratorAdapter<T, U>")]
    public class DictionaryIteratorAdapter_2_Tests
    {
        [Fact]
        public void Test_DictionaryIteratorAdapter_2_Begin_Ctor_WithEmptyDictionary()
        {
            var dictionary = new Dictionary<string, int>();
            Iterator<string, int> it = dictionary.Begin();

            it.Should().NotBeNull();
            it.IsEndIterator.Should().BeFalse();
            it.Index.Should().Be(-1);
            it.Current.Should().NotBeNull();
            it.Key.Should().BeNull();
            it.Value.Should().Be(0);
        }

        [Fact]
        public void Test_DictionaryIteratorAdapter_2_End_Ctor_WithEmptyDictionary()
        {
            var dictionary = new Dictionary<string, int>();
            Iterator<string, int> it = dictionary.End();

            it.Should().NotBeNull();
            it.IsEndIterator.Should().BeTrue();
            it.Index.Should().Be(-1);
            it.Current.Should().NotBeNull();
            it.Key.Should().BeNull();
            it.Value.Should().Be(0);
        }

        [Fact]
        public void Test_DictionaryIteratorAdapter_2_Begin_Iteration_WithEmptyDictionary()
        {
            var dictionary = new Dictionary<string, int>();
            Iterator<string, int> it = dictionary.Begin();

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
        public void Test_DictionaryIteratorAdapter_2_End_Iteration_WithEmptyDictionary()
        {
            var dictionary = new Dictionary<string, int>();
            Iterator<string, int> it = dictionary.End();

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
        public void Test_DictionaryIteratorAdapter_2_Begin_Ctor_WithNotEmptyDictionary()
        {
            var dictionary = new Dictionary<string, int>
            {
                ["one"] = 1,
                ["two"] = 2,
                ["three"] = 3,
                ["four"] = 4,
                ["five"] = 5
            };

            Iterator<string, int> it = dictionary.Begin();

            it.Should().NotBeNull();
            it.IsEndIterator.Should().BeFalse();
            it.Index.Should().Be(-1);
            it.Current.Should().NotBeNull();
            it.Key.Should().BeNull();
            it.Value.Should().Be(0);
        }

        [Fact]
        public void Test_DictionaryIteratorAdapter_2_End_Ctor_WithNotEmptyDictionary()
        {
            var dictionary = new Dictionary<string, int>
            {
                ["one"] = 1,
                ["two"] = 2,
                ["three"] = 3,
                ["four"] = 4,
                ["five"] = 5
            };

            Iterator<string, int> it = dictionary.End();

            it.Should().NotBeNull();
            it.IsEndIterator.Should().BeTrue();
            it.Index.Should().Be(-1);
            it.Current.Should().NotBeNull();
            it.Key.Should().BeNull();
            it.Value.Should().Be(0);
        }

        [Fact]
        public void Test_DictionaryIteratorAdapter_2_Begin_Iteration_WithNotEmptyDictionary()
        {
            var dictionary = new Dictionary<string, int>
            {
                ["one"] = 1,
                ["two"] = 2,
                ["three"] = 3,
                ["four"] = 4,
                ["five"] = 5
            };

            Iterator<string, int> it = dictionary.Begin();

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
            it.Index.Should().Be(dictionary.Count);
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
        public void Test_DictionaryIteratorAdapter_2_End_Iteration_WithNotEmptyDictionary()
        {
            var dictionary = new Dictionary<string, int>
            {
                ["one"] = 1,
                ["two"] = 2,
                ["three"] = 3,
                ["four"] = 4,
                ["five"] = 5
            };

            Iterator<string, int> it = dictionary.End();

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
            it.Index.Should().Be(dictionary.Count);
            it.Current.Should().NotBeNull();
            it.Key.Should().BeNull();
            it.Value.Should().Be(0);
        }

        [Fact]
        public void Test_DictionaryIteratorAdapter_2_Begin_Assignment()
        {
            var dictionary = new Dictionary<string, int>
            {
                ["one"] = 1,
                ["two"] = 2,
                ["three"] = 3,
                ["four"] = 4,
                ["five"] = 5
            };

            var expectedDictionary = new Dictionary<string, int>
            {
                ["one"] = 1,
                ["two"] = 2,
                ["seven"] = 7,
                ["four"] = 4,
                ["five"] = 5
            };

            Iterator<string, int> it = dictionary.Begin();

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
            dictionary.Should().Contain(expectedDictionary);
        }

        [Fact]
        public void Test_DictionaryIteratorAdapter_2_End_Assignment()
        {
            var dictionary = new Dictionary<string, int>
            {
                ["one"] = 1,
                ["two"] = 2,
                ["three"] = 3,
                ["four"] = 4,
                ["five"] = 5
            };

            var expectedDictionary = new Dictionary<string, int>
            {
                ["one"] = 1,
                ["two"] = 2,
                ["three"] = 3,
                ["four"] = 4,
                ["five"] = 5
            };

            Iterator<string, int> it = dictionary.End();

            it.IsEndIterator.Should().BeTrue();
            it.Index.Should().Be(-1);
            it.Current.Should().NotBeNull();
            it.Key.Should().BeNull();
            it.Value.Should().Be(0);

            it.Current = new KeyValuePair<string, int>("seven", 7);
            it.IsEndIterator.Should().BeTrue();
            it.Index.Should().Be(-1);
            dictionary.Should().Contain(expectedDictionary);
        }

        [Fact]
        public void Test_DictionaryIteratorAdapter_2_Begin_Assignment_IndexOutOfBound()
        {
            var dictionary = new Dictionary<string, int>
            {
                ["one"] = 1,
                ["two"] = 2,
                ["three"] = 3,
                ["four"] = 4,
                ["five"] = 5
            };

            var expectedDictionary = new Dictionary<string, int>
            {
                ["one"] = 1,
                ["two"] = 2,
                ["three"] = 3,
                ["four"] = 4,
                ["five"] = 5
            };

            Iterator<string, int> it = dictionary.Begin();

            it.IsEndIterator.Should().BeFalse();
            it.Index.Should().Be(-1);
            it.Current.Should().NotBeNull();
            it.Key.Should().BeNull();
            it.Value.Should().Be(0);

            it.Current = new KeyValuePair<string, int>("seven", 7);
            it.IsEndIterator.Should().BeFalse();
            it.Index.Should().Be(-1);
            dictionary.Should().Contain(expectedDictionary);
        }

        [Fact]
        public void Test_DictionaryIteratorAdapter_2_Begin_IsValid()
        {
            var dictionary = new Dictionary<string, int>
            {
                ["one"] = 1,
                ["two"] = 2,
                ["three"] = 3,
                ["four"] = 4,
                ["five"] = 5
            };

            Iterator<string, int> it = dictionary.Begin();

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
        public void Test_DictionaryIteratorAdapter_2_End_IsValid()
        {
            var dictionary = new Dictionary<string, int>
            {
                ["one"] = 1,
                ["two"] = 2,
                ["three"] = 3,
                ["four"] = 4,
                ["five"] = 5
            };

            Iterator<string, int> it = dictionary.End();

            it.IsEndIterator.Should().BeTrue();
            it.Index.Should().Be(-1);
            it.IsValid.Should().BeFalse();
        }
    }
}
