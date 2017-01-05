namespace Iterator.Performance.Tests.NotConst
{
    using BenchmarkDotNet.Attributes;
    using BenchmarkDotNet.Attributes.Columns;
    using RangeIt.Iterators;
    using System;

    [MinColumn, MaxColumn]
    public class Array_1_Iterator_Vs_Enumerator_Tests
    {
        private readonly int[] _arrayInts = new int[Constants.MAX_ITEMS];
        private readonly string[] _arrayStrings = new string[Constants.MAX_ITEMS];
        private readonly Random _random = new Random();

        [Setup]
        public void Setup()
        {
            var max = Constants.MAX_ITEMS;

            for (int i = 0; i < max; i++)
                _arrayInts[i] = _random.Next(max);

            for (int i = 0; i < max; i++)
                _arrayStrings[i] = _random.Next(max).ToString();
        }

        [Benchmark]
        public void Array_1_Integer_Iterator()
        {
            var it = _arrayInts.Begin();
            while (it++) { }
        }

        [Benchmark]
        public void Array_1_Integer_Enumerator()
        {
            foreach (var i in _arrayInts) { }
        }

        [Benchmark]
        public void Array_1_String_Iterator()
        {
            var it = _arrayStrings.Begin();
            while (it++) { }
        }

        [Benchmark]
        public void Array_1_String_Enumerator()
        {
            foreach (var s in _arrayStrings) { }
        }
    }
}
