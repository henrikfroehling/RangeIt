﻿namespace Iterator.Performance.Tests.NotConst
{
    using BenchmarkDotNet.Attributes;
    using BenchmarkDotNet.Attributes.Columns;
    using RangeIt.Iterators;
    using System;
    using System.Collections.Generic;

    [MinColumn, MaxColumn]
    public class Array_2_Iterator_Vs_Enumerator_Tests
    {
        private readonly KeyValuePair<int, int>[] _arrayInts = new KeyValuePair<int, int>[Constants.MAX_ITEMS];
        private readonly KeyValuePair<string, string>[] _arrayStrings = new KeyValuePair<string, string>[Constants.MAX_ITEMS];

        [Setup]
        public void Setup()
        {
            var rnd = new Random();
            var max = Constants.MAX_ITEMS;

            for (int i = 0; i < max; i++)
            {
                var value = rnd.Next(max);
                _arrayInts[i] = new KeyValuePair<int, int>(value, value);
            }

            for (int i = 0; i < max; i++)
            {
                var value = rnd.Next(max).ToString();
                _arrayStrings[i] = new KeyValuePair<string, string>(value, value);
            }
        }

        [Benchmark]
        public void Array_2_Integer_Iterator()
        {
            var it = _arrayInts.Begin();
            while (it.Next()) { }
        }

        [Benchmark]
        public void Array_2_Integer_Iterator_OperatorOverload()
        {
            var it = _arrayInts.Begin();
            while (it++) { }
        }

        [Benchmark]
        public void Array_2_Integer_Enumerator()
        {
            foreach (var i in _arrayInts) { }
        }

        [Benchmark]
        public void Array_2_String_Iterator()
        {
            var it = _arrayStrings.Begin();
            while (it.Next()) { }
        }

        [Benchmark]
        public void Array_2_String_Iterator_OperatorOverload()
        {
            var it = _arrayStrings.Begin();
            while (it++) { }
        }

        [Benchmark]
        public void Array_2_String_Enumerator()
        {
            foreach (var s in _arrayStrings) { }
        }
    }
}