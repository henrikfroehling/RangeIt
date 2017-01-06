namespace Iterator.Performance.Tests.NotConst
{
    using BenchmarkDotNet.Attributes;
    using BenchmarkDotNet.Attributes.Columns;
    using RangeIt.Iterators;
    using System;
    using System.Collections.Generic;

    [MinColumn, MaxColumn]
    public class Dictionary_2_Iterator_Vs_Enumerator_Tests
    {
        private readonly Dictionary<int, int> _dictionaryInts = new Dictionary<int, int>();
        private readonly Dictionary<string, string> _dictionaryStrings = new Dictionary<string, string>();

        private Iterator<int, int> _itInt;
        private Iterator<int, int> _itIntOp;
        private Iterator<string, string> _itString;
        private Iterator<string, string> _itStringOp;

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

            _itInt = _dictionaryInts.Begin();
            _itIntOp = _dictionaryInts.Begin();

            _itString = _dictionaryStrings.Begin();
            _itStringOp = _dictionaryStrings.Begin();
        }

        [Benchmark]
        public void Dictionary_2_Integer_Iterator()
        {
            while (_itInt.Next()) { }
        }

        [Benchmark]
        public void Dictionary_2_Integer_Iterator_OperatorOverload()
        {
            while (_itIntOp++) { }
        }

        [Benchmark]
        public void Dictionary_2_Integer_Enumerator()
        {
            foreach (var i in _dictionaryInts) { }
        }

        [Benchmark]
        public void Dictionary_2_String_Iterator()
        {
            while (_itString.Next()) { }
        }

        [Benchmark]
        public void Dictionary_2_String_Iterator_OperatorOverload()
        {
            while (_itStringOp++) { }
        }

        [Benchmark]
        public void Dictionary_2_String_Enumerator()
        {
            foreach (var s in _dictionaryStrings) { }
        }
    }
}
