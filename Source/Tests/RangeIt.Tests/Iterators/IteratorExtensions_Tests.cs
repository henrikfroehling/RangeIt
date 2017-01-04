namespace RangeIt.Tests.Iterators
{
    using FluentAssertions;
    using RangeIt.Iterators;
    using System.Collections;
    using System.Collections.Concurrent;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using Xunit;

    [Collection("IteratorExtensions.Tests")]
    public class IteratorExtensions_Tests
    {
        [Fact]
        public void Test_IteratorExtensions_Get_BeginIterator_For_ArrayList()
        {
            var arrayList = new ArrayList();
            var it = arrayList.Begin();
            it.Should().NotBeNull();
        }

        [Fact]
        public void Test_IteratorExtensions_Get_EndIterator_For_ArrayList()
        {
            var arrayList = new ArrayList();
            var it = arrayList.End();
            it.Should().NotBeNull();
        }

        [Fact]
        public void Test_IteratorExtensions_Get_BeginIterator_For_SortedList()
        {
            var sortedList = new SortedList();
            var it = sortedList.Begin();
            it.Should().NotBeNull();
        }

        [Fact]
        public void Test_IteratorExtensions_Get_EndIterator_For_SortedList()
        {
            var sortedList = new SortedList();
            var it = sortedList.End();
            it.Should().NotBeNull();
        }

        // ---------------------------------------------------------------

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

        [Fact]
        public void Test_IteratorExtensions_Get_BeginIterator_1_For_ConcurrentQueue()
        {
            var queue = new ConcurrentQueue<int>();
            var it = queue.Begin();
            it.Should().NotBeNull();
        }

        [Fact]
        public void Test_IteratorExtensions_Get_EndIterator_1_For_ConcurrentQueue()
        {
            var queue = new ConcurrentQueue<int>();
            var it = queue.End();
            it.Should().NotBeNull();
        }

        [Fact]
        public void Test_IteratorExtensions_Get_BeginIterator_1_For_ConcurrentStack()
        {
            var stack = new ConcurrentStack<int>();
            var it = stack.Begin();
            it.Should().NotBeNull();
        }

        [Fact]
        public void Test_IteratorExtensions_Get_EndIterator_1_For_ConcurrentStack()
        {
            var stack = new ConcurrentStack<int>();
            var it = stack.End();
            it.Should().NotBeNull();
        }

        [Fact]
        public void Test_IteratorExtensions_Get_BeginIterator_1_For_ConcurrentBag()
        {
            var bag = new ConcurrentBag<int>();
            var it = bag.Begin();
            it.Should().NotBeNull();
        }

        [Fact]
        public void Test_IteratorExtensions_Get_EndIterator_1_For_ConcurrentBag()
        {
            var bag = new ConcurrentBag<int>();
            var it = bag.End();
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
        public void Test_IteratorExtensions_Get_Const_BeginIterator_For_ArrayList()
        {
            var arrayList = new ArrayList();
            var it = arrayList.ConstBegin();
            it.Should().NotBeNull();
        }

        [Fact]
        public void Test_IteratorExtensions_Get_Const_EndIterator_For_ArrayList()
        {
            var arrayList = new ArrayList();
            var it = arrayList.ConstEnd();
            it.Should().NotBeNull();
        }

        [Fact]
        public void Test_IteratorExtensions_Get_Const_BeginIterator_For_SortedList()
        {
            var sortedList = new SortedList();
            var it = sortedList.ConstBegin();
            it.Should().NotBeNull();
        }

        [Fact]
        public void Test_IteratorExtensions_Get_Const_EndIterator_For_SortedList()
        {
            var sortedList = new SortedList();
            var it = sortedList.ConstEnd();
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

        [Fact]
        public void Test_IteratorExtensions_Get_Const_BeginIterator_1_For_ConcurrentQueue()
        {
            var queue = new ConcurrentQueue<int>();
            var it = queue.ConstBegin();
            it.Should().NotBeNull();
        }

        [Fact]
        public void Test_IteratorExtensions_Get_Const_EndIterator_1_For_ConcurrentQueue()
        {
            var queue = new ConcurrentQueue<int>();
            var it = queue.ConstEnd();
            it.Should().NotBeNull();
        }

        [Fact]
        public void Test_IteratorExtensions_Get_Const_BeginIterator_1_For_ConcurrentStack()
        {
            var stack = new ConcurrentStack<int>();
            var it = stack.ConstBegin();
            it.Should().NotBeNull();
        }

        [Fact]
        public void Test_IteratorExtensions_Get_Const_EndIterator_1_For_ConcurrentStack()
        {
            var stack = new ConcurrentStack<int>();
            var it = stack.ConstEnd();
            it.Should().NotBeNull();
        }

        [Fact]
        public void Test_IteratorExtensions_Get_Const_BeginIterator_1_For_ConcurrentBag()
        {
            var bag = new ConcurrentBag<int>();
            var it = bag.ConstBegin();
            it.Should().NotBeNull();
        }

        [Fact]
        public void Test_IteratorExtensions_Get_Const_EndIterator_1_For_ConcurrentBag()
        {
            var bag = new ConcurrentBag<int>();
            var it = bag.ConstEnd();
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
