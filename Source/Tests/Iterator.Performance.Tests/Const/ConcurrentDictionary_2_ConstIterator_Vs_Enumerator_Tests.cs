namespace Iterator.Performance.Tests.Const
{
    using BenchmarkDotNet.Attributes;
    using BenchmarkDotNet.Attributes.Columns;
    using RangeIt.Iterators;
    using System;
    using System.Collections.Concurrent;
    using System.Collections.Generic;

    [MinColumn, MaxColumn]
    public class ConcurrentDictionary_2_ConstIterator_Vs_Enumerator_Tests
    {
        private readonly ConcurrentDictionary<int, int> _dictionaryInts = new ConcurrentDictionary<int, int>();
        private readonly ConcurrentDictionary<string, string> _dictionaryStrings = new ConcurrentDictionary<string, string>();

        private ConstIterator<int, int> _itInt;
        private ConstIterator<int, int> _itIntOp;
        private ConstIterator<string, string> _itString;
        private ConstIterator<string, string> _itStringOp;

        [GlobalSetup]
        public void Setup()
        {
            var rnd = new Random();
            const int max = Constants.MAX_ITEMS;

            for (int i = 0; i < max; i++)
            {
                int value = rnd.Next(max);
                _dictionaryInts.TryAdd(i, value);
            }

            for (int i = 0; i < max; i++)
            {
                string value = rnd.Next(max).ToString();
                _dictionaryStrings.TryAdd(i.ToString(), value);
            }

            _itInt = _dictionaryInts.ConstBegin();
            _itIntOp = _dictionaryInts.ConstBegin();

            _itString = _dictionaryStrings.ConstBegin();
            _itStringOp = _dictionaryStrings.ConstBegin();
        }

        [Benchmark]
        public void ConcurrentDictionary_2_Integer_ConstIterator()
        {
            while (_itInt.Next()) { }
        }

        [Benchmark]
        public void ConcurrentDictionary_2_Integer_ConstIterator_OperatorOverload()
        {
            while (_itIntOp++) { }
        }

        [Benchmark]
        public void ConcurrentDictionary_2_Integer_Enumerator()
        {
            foreach (KeyValuePair<int, int> i in _dictionaryInts) { }
        }

        [Benchmark]
        public void ConcurrentDictionary_2_String_ConstIterator()
        {
            while (_itString.Next()) { }
        }

        [Benchmark]
        public void ConcurrentDictionary_2_String_ConstIterator_OperatorOverload()
        {
            while (_itStringOp++) { }
        }

        [Benchmark]
        public void ConcurrentDictionary_2_String_Enumerator()
        {
            foreach (KeyValuePair<string, string> s in _dictionaryStrings) { }
        }
    }
}
