﻿namespace Iterator.Performance.Tests.NotConst
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
        public void SortedList_Integer_Iterator()
        {
            var it = _sortedListInts.Begin();
            while (it++) { }
        }

        [Benchmark]
        public void SortedList_Integer_Enumerator()
        {
            foreach (var i in _sortedListInts) { }
        }

        [Benchmark]
        public void SortedList_String_Iterator()
        {
            var it = _sortedListStrings.Begin();
            while (it++) { }
        }

        [Benchmark]
        public void SortedList_String_Enumerator()
        {
            foreach (var s in _sortedListStrings) { }
        }
    }
}
