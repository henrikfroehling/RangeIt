namespace Iterator.Performance.Tests.NotConst
{
    using BenchmarkDotNet.Attributes;
    using BenchmarkDotNet.Attributes.Columns;
    using RangeIt.Iterators;
    using System;
    using System.Collections.Generic;

    [MinColumn, MaxColumn]
    public class List_1_Iterator_Vs_Enumerator_Tests
    {
        private readonly List<int> _listInts = new List<int>();
        private readonly List<string> _listStrings = new List<string>();
        private readonly Random _random = new Random();

        [Setup]
        public void Setup()
        {
            var max = Constants.MAX_ITEMS;

            for (int i = 0; i < max; i++)
                _listInts.Add(_random.Next(max));

            for (int i = 0; i < max; i++)
                _listStrings.Add(_random.Next(max).ToString());
        }

        [Benchmark]
        public void List_1_Integer_Iterator()
        {
            var it = _listInts.Begin();
            while (it++) { }
        }

        [Benchmark]
        public void List_1_Integer_Enumerator()
        {
            foreach (var i in _listInts) { }
        }

        [Benchmark]
        public void List_1_String_Iterator()
        {
            var it = _listStrings.Begin();
            while (it++) { }
        }

        [Benchmark]
        public void List_1_String_Enumerator()
        {
            foreach (var s in _listStrings) { }
        }
    }
}
