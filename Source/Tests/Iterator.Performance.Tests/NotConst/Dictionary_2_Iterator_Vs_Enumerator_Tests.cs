﻿namespace Iterator.Performance.Tests.NotConst
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

        [GlobalSetup]
        public void Setup()
        {
            var rnd = new Random();
            const int max = Constants.MAX_ITEMS;

            for (int i = 0; i < max; i++)
                _dictionaryInts[i] = rnd.Next(max);

            for (int i = 0; i < max; i++)
                _dictionaryStrings[i.ToString()] = rnd.Next(max).ToString();

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
            foreach (KeyValuePair<int, int> i in _dictionaryInts) { }
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
            foreach (KeyValuePair<string, string> s in _dictionaryStrings) { }
        }
    }
}
