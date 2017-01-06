namespace RangeIt.Tests.Iterators
{
    using FluentAssertions;
    using RangeIt.Iterators;
    using System.Collections.Concurrent;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using Xunit;

    [Collection("IteratorExtensions.Tests")]
    public class IteratorExtensions_Tests
    {
        [Fact]
        public void Test_IteratorExtensions_Get_BeginIterator_1_For_T_Array()
        {
            var array = new int[0];
            var it = array.Begin();
            it.Should().NotBeNull();
        }

        [Fact]
        public void Test_IteratorExtensions_Get_EndIterator_1_For_T_Array()
        {
            var array = new int[0];
            var it = array.End();
            it.Should().NotBeNull();
        }

        [Fact]
        public void Test_IteratorExtensions_Get_BeginIterator_1_For_List()
        {
            var list = new List<int>();
            var it = list.Begin();
            it.Should().NotBeNull();
        }

        [Fact]
        public void Test_IteratorExtensions_Get_EndIterator_1_For_List()
        {
            var list = new List<int>();
            var it = list.End();
            it.Should().NotBeNull();
        }

        [Fact]
        public void Test_IteratorExtensions_Get_BeginIterator_1_For_Collection()
        {
            var collection = new Collection<int>();
            var it = collection.Begin();
            it.Should().NotBeNull();
        }

        [Fact]
        public void Test_IteratorExtensions_Get_EndIterator_1_For_Collection()
        {
            var collection = new Collection<int>();
            var it = collection.End();
            it.Should().NotBeNull();
        }

        // ---------------------------------------------------------------

        [Fact]
        public void Test_IteratorExtensions_Get_BeginIterator_2_For_KeyValuePair_Array()
        {
            var array = new KeyValuePair<int, float>[0];
            var it = array.Begin();
            it.Should().NotBeNull();
        }

        [Fact]
        public void Test_IteratorExtensions_Get_EndIterator_2_For_KeyValuePair_Array()
        {
            var array = new KeyValuePair<int, float>[0];
            var it = array.End();
            it.Should().NotBeNull();
        }

        [Fact]
        public void Test_IteratorExtensions_Get_BeginIterator_2_For_Dictionary()
        {
            var dictionary = new Dictionary<int, float>();
            var it = dictionary.Begin();
            it.Should().NotBeNull();
        }

        [Fact]
        public void Test_IteratorExtensions_Get_EndIterator_2_For_Dictionary()
        {
            var dictionary = new Dictionary<int, float>();
            var it = dictionary.End();
            it.Should().NotBeNull();
        }

        [Fact]
        public void Test_IteratorExtensions_Get_BeginIterator_2_For_ConcurrentDictionary()
        {
            var dictionary = new ConcurrentDictionary<int, float>();
            var it = dictionary.Begin();
            it.Should().NotBeNull();
        }

        [Fact]
        public void Test_IteratorExtensions_Get_EndIterator_2_For_ConcurrentDictionary()
        {
            var dictionary = new ConcurrentDictionary<int, float>();
            var it = dictionary.End();
            it.Should().NotBeNull();
        }

        // ---------------------------------------------------------------

        [Fact]
        public void Test_IteratorExtensions_Get_Const_BeginIterator_1_For_T_Array()
        {
            var array = new int[0];
            var it = array.ConstBegin();
            it.Should().NotBeNull();
        }

        [Fact]
        public void Test_IteratorExtensions_Get_Const_EndIterator_1_For_T_Array()
        {
            var array = new int[0];
            var it = array.ConstEnd();
            it.Should().NotBeNull();
        }

        [Fact]
        public void Test_IteratorExtensions_Get_Const_BeginIterator_1_For_List()
        {
            var list = new List<int>();
            var it = list.ConstBegin();
            it.Should().NotBeNull();
        }

        [Fact]
        public void Test_IteratorExtensions_Get_Const_EndIterator_1_For_List()
        {
            var list = new List<int>();
            var it = list.ConstEnd();
            it.Should().NotBeNull();
        }

        [Fact]
        public void Test_IteratorExtensions_Get_Const_BeginIterator_1_For_Collection()
        {
            var collection = new Collection<int>();
            var it = collection.ConstBegin();
            it.Should().NotBeNull();
        }

        [Fact]
        public void Test_IteratorExtensions_Get_Const_EndIterator_1_For_Collection()
        {
            var collection = new Collection<int>();
            var it = collection.ConstEnd();
            it.Should().NotBeNull();
        }

        [Fact]
        public void Test_IteratorExtensions_Get_Const_BeginIterator_1_For_ReadOnlyCollection()
        {
            var collection = new Collection<int>();
            var readOnlyCollection = new ReadOnlyCollection<int>(collection);
            var it = readOnlyCollection.ConstBegin();
            it.Should().NotBeNull();
        }

        [Fact]
        public void Test_IteratorExtensions_Get_Const_EndIterator_1_For_ReadOnlyCollection()
        {
            var collection = new Collection<int>();
            var readOnlyCollection = new ReadOnlyCollection<int>(collection);
            var it = readOnlyCollection.ConstEnd();
            it.Should().NotBeNull();
        }

        // ---------------------------------------------------------------

        [Fact]
        public void Test_IteratorExtensions_Get_Const_BeginIterator_2_For_KeyValuePair_Array()
        {
            var array = new KeyValuePair<int, float>[0];
            var it = array.ConstBegin();
            it.Should().NotBeNull();
        }

        [Fact]
        public void Test_IteratorExtensions_Get_Const_EndIterator_2_For_KeyValuePair_Array()
        {
            var array = new KeyValuePair<int, float>[0];
            var it = array.ConstEnd();
            it.Should().NotBeNull();
        }

        [Fact]
        public void Test_IteratorExtensions_Get_Const_BeginIterator_2_For_Dictionary()
        {
            var dictionary = new Dictionary<int, float>();
            var it = dictionary.ConstBegin();
            it.Should().NotBeNull();
        }

        [Fact]
        public void Test_IteratorExtensions_Get_Const_EndIterator_2_For_Dictionary()
        {
            var dictionary = new Dictionary<int, float>();
            var it = dictionary.ConstEnd();
            it.Should().NotBeNull();
        }

        [Fact]
        public void Test_IteratorExtensions_Get_Const_BeginIterator_2_For_ReadOnlyDictionary()
        {
            var dictionary = new Dictionary<int, float>();
            var readOnlyDictionary = new ReadOnlyDictionary<int, float>(dictionary);
            var it = readOnlyDictionary.ConstBegin();
            it.Should().NotBeNull();
        }

        [Fact]
        public void Test_IteratorExtensions_Get_Const_EndIterator_2_For_ReadOnlyDictionary()
        {
            var dictionary = new Dictionary<int, float>();
            var readOnlyDictionary = new ReadOnlyDictionary<int, float>(dictionary);
            var it = readOnlyDictionary.ConstEnd();
            it.Should().NotBeNull();
        }

        [Fact]
        public void Test_IteratorExtensions_Get_Const_BeginIterator_2_For_ConcurrentDictionary()
        {
            var dictionary = new ConcurrentDictionary<int, float>();
            var it = dictionary.ConstBegin();
            it.Should().NotBeNull();
        }

        [Fact]
        public void Test_IteratorExtensions_Get_Const_EndIterator_2_For_ConcurrentDictionary()
        {
            var dictionary = new ConcurrentDictionary<int, float>();
            var it = dictionary.ConstEnd();
            it.Should().NotBeNull();
        }
    }
}
