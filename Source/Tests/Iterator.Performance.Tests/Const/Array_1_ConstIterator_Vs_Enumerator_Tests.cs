namespace Iterator.Performance.Tests.Const
{
    using BenchmarkDotNet.Attributes;
    using BenchmarkDotNet.Attributes.Columns;
    using RangeIt.Iterators;
    using System;

    [MinColumn, MaxColumn]
    public class Array_1_ConstIterator_Vs_Enumerator_Tests
    {
        private readonly int[] _arrayInts = new int[Constants.MAX_ITEMS];
        private readonly string[] _arrayStrings = new string[Constants.MAX_ITEMS];

        [Setup]
        public void Setup()
        {
            var rnd = new Random();
            var max = Constants.MAX_ITEMS;

            for (int i = 0; i < max; i++)
                _arrayInts[i] = rnd.Next(max);

            for (int i = 0; i < max; i++)
                _arrayStrings[i] = rnd.Next(max).ToString();
        }

        [Benchmark]
        public void Array_1_Integer_ConstIterator()
        {
            var it = _arrayInts.ConstBegin();
            while (it.Next()) { }
        }

        [Benchmark]
        public void Array_1_Integer_ConstIterator_OperatorOverload()
        {
            var it = _arrayInts.ConstBegin();
            while (it++) { }
        }

        [Benchmark]
        public void Array_1_Integer_Enumerator()
        {
            foreach (var i in _arrayInts) { }
        }

        [Benchmark]
        public void Array_1_String_ConstIterator()
        {
            var it = _arrayStrings.ConstBegin();
            while (it.Next()) { }
        }

        [Benchmark]
        public void Array_1_String_ConstIterator_OperatorOverload()
        {
            var it = _arrayStrings.ConstBegin();
            while (it++) { }
        }

        [Benchmark]
        public void Array_1_String_Enumerator()
        {
            foreach (var s in _arrayStrings) { }
        }
    }
}
