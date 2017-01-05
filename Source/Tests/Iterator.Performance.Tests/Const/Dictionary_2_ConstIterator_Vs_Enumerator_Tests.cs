namespace Iterator.Performance.Tests.Const
{
    using BenchmarkDotNet.Attributes;
    using BenchmarkDotNet.Attributes.Columns;
    using RangeIt.Iterators;
    using System;
    using System.Collections.Generic;

    [MinColumn, MaxColumn]
    public class Dictionary_2_ConstIterator_Vs_Enumerator_Tests
    {
        private readonly Dictionary<int, int> _dictionaryInts = new Dictionary<int, int>(Constants.MAX_ITEMS);
        private readonly Dictionary<string, string> _dictionaryStrings = new Dictionary<string, string>(Constants.MAX_ITEMS);

        [Setup]
        public void Setup()
        {
            var rnd = new Random();
            var max = Constants.MAX_ITEMS;

            for (int i = 0; i < max; i++)
            {
                var value = rnd.Next(max);
                _dictionaryInts[i] = value;
            }

            for (int i = 0; i < max; i++)
            {
                var value = rnd.Next(max).ToString();
                _dictionaryStrings[i.ToString()] = value;
            }
        }

        [Benchmark]
        public void Dictionary_2_Integer_ConstIterator()
        {
            var it = _dictionaryInts.ConstBegin();
            while (it++) { }
        }

        [Benchmark]
        public void Dictionary_2_Integer_Enumerator()
        {
            foreach (var i in _dictionaryInts) { }
        }

        [Benchmark]
        public void Dictionary_2_String_ConstIterator()
        {
            var it = _dictionaryStrings.ConstBegin();
            while (it++) { }
        }

        [Benchmark]
        public void Dictionary_2_String_Enumerator()
        {
            foreach (var s in _dictionaryStrings) { }
        }
    }
}
