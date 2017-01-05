namespace Iterator.Performance.Tests.Const
{
    using BenchmarkDotNet.Attributes;
    using BenchmarkDotNet.Attributes.Columns;
    using RangeIt.Iterators;
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    [MinColumn, MaxColumn]
    public class ReadOnlyDictionary_2_ConstIterator_Vs_Enumerator_Tests
    {
        private readonly Dictionary<int, int> _dictionaryInts = new Dictionary<int, int>();
        private readonly Dictionary<string, string> _dictionaryStrings = new Dictionary<string, string>();

        private ReadOnlyDictionary<int, int> _readOnlyDictionaryInts;
        private ReadOnlyDictionary<string, string> _readOnlyDictionaryStrings;

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


            _readOnlyDictionaryInts = new ReadOnlyDictionary<int, int>(_dictionaryInts);
            _readOnlyDictionaryStrings = new ReadOnlyDictionary<string, string>(_dictionaryStrings);
        }

        [Benchmark]
        public void ReadOnlyDictionary_2_Integer_ConstIterator_OperatorOverload()
        {
            var it = _readOnlyDictionaryInts.ConstBegin();
            while (it++) { }
        }

        [Benchmark]
        public void ReadOnlyDictionary_2_Integer_Enumerator()
        {
            foreach (var i in _readOnlyDictionaryInts) { }
        }

        [Benchmark]
        public void ReadOnlyDictionary_2_String_ConstIterator_OperatorOverload()
        {
            var it = _readOnlyDictionaryStrings.ConstBegin();
            while (it++) { }
        }

        [Benchmark]
        public void ReadOnlyDictionary_2_String_Enumerator()
        {
            foreach (var s in _readOnlyDictionaryStrings) { }
        }
    }
}
