namespace Iterator.Performance.Tests.Const
{
    using BenchmarkDotNet.Attributes;
    using BenchmarkDotNet.Attributes.Columns;
    using RangeIt.Iterators;
    using System;
    using System.Collections.Concurrent;

    [MinColumn, MaxColumn]
    public class ConcurrentDictionary_2_ConstIterator_Vs_Enumerator_Tests
    {
        private readonly ConcurrentDictionary<int, int> _dictionaryInts = new ConcurrentDictionary<int, int>();
        private readonly ConcurrentDictionary<string, string> _dictionaryStrings = new ConcurrentDictionary<string, string>();

        [Setup]
        public void Setup()
        {
            var rnd = new Random();
            var max = Constants.MAX_ITEMS;

            for (int i = 0; i < max; i++)
            {
                var value = rnd.Next(max);
                _dictionaryInts.TryAdd(i, value);
            }

            for (int i = 0; i < max; i++)
            {
                var value = rnd.Next(max).ToString();
                _dictionaryStrings.TryAdd(i.ToString(), value);
            }
        }

        [Benchmark]
        public void ConcurrentDictionary_2_Integer_ConstIterator()
        {
            var it = _dictionaryInts.ConstBegin();
            while (it.Next()) { }
        }

        [Benchmark]
        public void ConcurrentDictionary_2_Integer_ConstIterator_OperatorOverload()
        {
            var it = _dictionaryInts.ConstBegin();
            while (it++) { }
        }

        [Benchmark]
        public void ConcurrentDictionary_2_Integer_Enumerator()
        {
            foreach (var i in _dictionaryInts) { }
        }

        [Benchmark]
        public void ConcurrentDictionary_2_String_ConstIterator()
        {
            var it = _dictionaryStrings.ConstBegin();
            while (it.Next()) { }
        }

        [Benchmark]
        public void ConcurrentDictionary_2_String_ConstIterator_OperatorOverload()
        {
            var it = _dictionaryStrings.ConstBegin();
            while (it++) { }
        }

        [Benchmark]
        public void ConcurrentDictionary_2_String_Enumerator()
        {
            foreach (var s in _dictionaryStrings) { }
        }
    }
}
