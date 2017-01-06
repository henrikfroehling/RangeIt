namespace Iterator.Performance.Tests.NotConst
{
    using BenchmarkDotNet.Attributes;
    using BenchmarkDotNet.Attributes.Columns;
    using RangeIt.Iterators;
    using System.Collections;

    [MinColumn, MaxColumn]
    public class SortedList_Iterator_Vs_Enumerator_Tests
    {
        private readonly SortedList _sortedListInts = new SortedList();
        private readonly SortedList _sortedListStrings = new SortedList();

        private Iterator _itInt;
        private Iterator _itIntOp;
        private Iterator _itString;
        private Iterator _itStringOp;

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

            _itInt = _sortedListInts.Begin();
            _itIntOp = _sortedListInts.Begin();

            _itString = _sortedListStrings.Begin();
            _itStringOp = _sortedListStrings.Begin();
        }

        [Benchmark]
        public void SortedList_Integer_Iterator()
        {
            while (_itInt.Next()) { }
        }

        [Benchmark]
        public void SortedList_Integer_Iterator_OperatorOverload()
        {
            while (_itIntOp++) { }
        }

        [Benchmark]
        public void SortedList_Integer_Enumerator()
        {
            foreach (var i in _sortedListInts) { }
        }

        [Benchmark]
        public void SortedList_String_Iterator()
        {
            while (_itString.Next()) { }
        }

        [Benchmark]
        public void SortedList_String_Iterator_OperatorOverload()
        {
            while (_itStringOp++) { }
        }

        [Benchmark]
        public void SortedList_String_Enumerator()
        {
            foreach (var s in _sortedListStrings) { }
        }
    }
}
