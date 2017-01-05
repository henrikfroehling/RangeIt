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

        private ConstIterator _itInt;
        private ConstIterator _itIntOp;
        private ConstIterator _itString;
        private ConstIterator _itStringOp;

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

            _itInt = _sortedListInts.ConstBegin();
            _itIntOp = _sortedListInts.ConstBegin();

            _itString = _sortedListStrings.ConstBegin();
            _itStringOp = _sortedListStrings.ConstBegin();
        }

        [Benchmark]
        public void SortedList_Integer_ConstIterator()
        {
            while (_itInt.Next()) { }
        }

        [Benchmark]
        public void SortedList_Integer_ConstIterator_OperatorOverload()
        {
            while (_itIntOp++) { }
        }

        [Benchmark]
        public void SortedList_Integer_Enumerator()
        {
            foreach (var i in _sortedListInts) { }
        }

        [Benchmark]
        public void SortedList_String_ConstIterator()
        {
            while (_itString.Next()) { }
        }

        [Benchmark]
        public void SortedList_String_ConstIterator_OperatorOverload()
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
