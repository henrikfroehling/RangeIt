namespace Iterator.Performance.Tests.Const
{
    using BenchmarkDotNet.Attributes;
    using BenchmarkDotNet.Attributes.Columns;
    using RangeIt.Iterators;
    using System.Collections;

    [MinColumn, MaxColumn]
    public class SortedList_ConstIterator_Vs_Enumerator_Tests
    {
        private readonly SortedList _sortedListInts = new SortedList();
        private readonly SortedList _sortedListStrings = new SortedList();

        [Setup]
        public void Setup()
        {
            var max = Constants.MAX_ITEMS;

            for (int i = 0; i < max; i++)
                _sortedListInts.Add(i, i);

            for (int i = 0; i < max; i++)
            {
                var value = i.ToString();
                _sortedListStrings.Add(value, value);
            }
        }

        [Benchmark]
        public void SortedList_Integer_ConstIterator_OperatorOverload()
        {
            var it = _sortedListInts.ConstBegin();
            while (it++) { }
        }

        [Benchmark]
        public void SortedList_Integer_Enumerator()
        {
            foreach (var i in _sortedListInts) { }
        }

        [Benchmark]
        public void SortedList_String_ConstIterator_OperatorOverload()
        {
            var it = _sortedListStrings.ConstBegin();
            while (it++) { }
        }

        [Benchmark]
        public void SortedList_String_Enumerator()
        {
            foreach (var s in _sortedListStrings) { }
        }
    }
}
