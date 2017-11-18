namespace RangeIt.Tests.Iterators
{
    using FluentAssertions;
    using RangeIt.Iterators;
    using System.Collections.Concurrent;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using Traits;
    using Xunit;

    [Category("Iterators.IteratorExtensions")]
    public class IteratorExtensions_Tests
    {
        [Fact]
        public void Test_IteratorExtensions_Get_BeginIterator_1_For_T_Array()
        {
            var array = new int[0];
            Iterator<int> it = array.Begin();
            it.Should().NotBeNull();
        }

        [Fact]
        public void Test_IteratorExtensions_Get_EndIterator_1_For_T_Array()
        {
            var array = new int[0];
            Iterator<int> it = array.End();
            it.Should().NotBeNull();
        }

        [Fact]
        public void Test_IteratorExtensions_Get_BeginIterator_1_For_List()
        {
            var list = new List<int>();
            Iterator<int> it = list.Begin();
            it.Should().NotBeNull();
        }

        [Fact]
        public void Test_IteratorExtensions_Get_EndIterator_1_For_List()
        {
            var list = new List<int>();
            Iterator<int> it = list.End();
            it.Should().NotBeNull();
        }

        [Fact]
        public void Test_IteratorExtensions_Get_BeginIterator_1_For_Collection()
        {
            var collection = new Collection<int>();
            Iterator<int> it = collection.Begin();
            it.Should().NotBeNull();
        }

        [Fact]
        public void Test_IteratorExtensions_Get_EndIterator_1_For_Collection()
        {
            var collection = new Collection<int>();
            Iterator<int> it = collection.End();
            it.Should().NotBeNull();
        }

        // ---------------------------------------------------------------

        [Fact]
        public void Test_IteratorExtensions_Get_BeginIterator_2_For_KeyValuePair_Array()
        {
            var array = new KeyValuePair<int, float>[0];
            Iterator<int, float> it = array.Begin();
            it.Should().NotBeNull();
        }

        [Fact]
        public void Test_IteratorExtensions_Get_EndIterator_2_For_KeyValuePair_Array()
        {
            var array = new KeyValuePair<int, float>[0];
            Iterator<int, float> it = array.End();
            it.Should().NotBeNull();
        }

        [Fact]
        public void Test_IteratorExtensions_Get_BeginIterator_2_For_Dictionary()
        {
            var dictionary = new Dictionary<int, float>();
            Iterator<int, float> it = dictionary.Begin();
            it.Should().NotBeNull();
        }

        [Fact]
        public void Test_IteratorExtensions_Get_EndIterator_2_For_Dictionary()
        {
            var dictionary = new Dictionary<int, float>();
            Iterator<int, float> it = dictionary.End();
            it.Should().NotBeNull();
        }

        [Fact]
        public void Test_IteratorExtensions_Get_BeginIterator_2_For_ConcurrentDictionary()
        {
            var dictionary = new ConcurrentDictionary<int, float>();
            Iterator<int, float> it = dictionary.Begin();
            it.Should().NotBeNull();
        }

        [Fact]
        public void Test_IteratorExtensions_Get_EndIterator_2_For_ConcurrentDictionary()
        {
            var dictionary = new ConcurrentDictionary<int, float>();
            Iterator<int, float> it = dictionary.End();
            it.Should().NotBeNull();
        }

        // ---------------------------------------------------------------

        [Fact]
        public void Test_IteratorExtensions_Get_Const_BeginIterator_1_For_T_Array()
        {
            var array = new int[0];
            ConstIterator<int> it = array.ConstBegin();
            it.Should().NotBeNull();
        }

        [Fact]
        public void Test_IteratorExtensions_Get_Const_EndIterator_1_For_T_Array()
        {
            var array = new int[0];
            ConstIterator<int> it = array.ConstEnd();
            it.Should().NotBeNull();
        }

        [Fact]
        public void Test_IteratorExtensions_Get_Const_BeginIterator_1_For_List()
        {
            var list = new List<int>();
            ConstIterator<int> it = list.ConstBegin();
            it.Should().NotBeNull();
        }

        [Fact]
        public void Test_IteratorExtensions_Get_Const_EndIterator_1_For_List()
        {
            var list = new List<int>();
            ConstIterator<int> it = list.ConstEnd();
            it.Should().NotBeNull();
        }

        [Fact]
        public void Test_IteratorExtensions_Get_Const_BeginIterator_1_For_Collection()
        {
            var collection = new Collection<int>();
            ConstIterator<int> it = collection.ConstBegin();
            it.Should().NotBeNull();
        }

        [Fact]
        public void Test_IteratorExtensions_Get_Const_EndIterator_1_For_Collection()
        {
            var collection = new Collection<int>();
            ConstIterator<int> it = collection.ConstEnd();
            it.Should().NotBeNull();
        }

        [Fact]
        public void Test_IteratorExtensions_Get_Const_BeginIterator_1_For_ReadOnlyCollection()
        {
            var collection = new Collection<int>();
            var readOnlyCollection = new ReadOnlyCollection<int>(collection);
            ConstIterator<int> it = readOnlyCollection.ConstBegin();
            it.Should().NotBeNull();
        }

        [Fact]
        public void Test_IteratorExtensions_Get_Const_EndIterator_1_For_ReadOnlyCollection()
        {
            var collection = new Collection<int>();
            var readOnlyCollection = new ReadOnlyCollection<int>(collection);
            ConstIterator<int> it = readOnlyCollection.ConstEnd();
            it.Should().NotBeNull();
        }

        // ---------------------------------------------------------------

        [Fact]
        public void Test_IteratorExtensions_Get_Const_BeginIterator_2_For_KeyValuePair_Array()
        {
            var array = new KeyValuePair<int, float>[0];
            ConstIterator<int, float> it = array.ConstBegin();
            it.Should().NotBeNull();
        }

        [Fact]
        public void Test_IteratorExtensions_Get_Const_EndIterator_2_For_KeyValuePair_Array()
        {
            var array = new KeyValuePair<int, float>[0];
            ConstIterator<int, float> it = array.ConstEnd();
            it.Should().NotBeNull();
        }

        [Fact]
        public void Test_IteratorExtensions_Get_Const_BeginIterator_2_For_Dictionary()
        {
            var dictionary = new Dictionary<int, float>();
            ConstIterator<int, float> it = dictionary.ConstBegin();
            it.Should().NotBeNull();
        }

        [Fact]
        public void Test_IteratorExtensions_Get_Const_EndIterator_2_For_Dictionary()
        {
            var dictionary = new Dictionary<int, float>();
            ConstIterator<int, float> it = dictionary.ConstEnd();
            it.Should().NotBeNull();
        }

        [Fact]
        public void Test_IteratorExtensions_Get_Const_BeginIterator_2_For_ReadOnlyDictionary()
        {
            var dictionary = new Dictionary<int, float>();
            var readOnlyDictionary = new ReadOnlyDictionary<int, float>(dictionary);
            ConstIterator<int, float> it = readOnlyDictionary.ConstBegin();
            it.Should().NotBeNull();
        }

        [Fact]
        public void Test_IteratorExtensions_Get_Const_EndIterator_2_For_ReadOnlyDictionary()
        {
            var dictionary = new Dictionary<int, float>();
            var readOnlyDictionary = new ReadOnlyDictionary<int, float>(dictionary);
            ConstIterator<int, float> it = readOnlyDictionary.ConstEnd();
            it.Should().NotBeNull();
        }

        [Fact]
        public void Test_IteratorExtensions_Get_Const_BeginIterator_2_For_ConcurrentDictionary()
        {
            var dictionary = new ConcurrentDictionary<int, float>();
            ConstIterator<int, float> it = dictionary.ConstBegin();
            it.Should().NotBeNull();
        }

        [Fact]
        public void Test_IteratorExtensions_Get_Const_EndIterator_2_For_ConcurrentDictionary()
        {
            var dictionary = new ConcurrentDictionary<int, float>();
            ConstIterator<int, float> it = dictionary.ConstEnd();
            it.Should().NotBeNull();
        }
    }
}
