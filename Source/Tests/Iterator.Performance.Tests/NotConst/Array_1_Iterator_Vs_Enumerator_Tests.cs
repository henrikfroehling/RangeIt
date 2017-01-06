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

        private Iterator<int> _itInt;
        private Iterator<int> _itIntOp;
        private Iterator<string> _itString;
        private Iterator<string> _itStringOp;

        [Setup]
        public void Setup()
        {
            var rnd = new Random();
            var max = Constants.MAX_ITEMS;

            for (int i = 0; i < max; i++)
                _arrayInts[i] = rnd.Next(max);

            for (int i = 0; i < max; i++)
                _arrayStrings[i] = rnd.Next(max).ToString();

            _itInt = _arrayInts.Begin();
            _itIntOp = _arrayInts.Begin();

            _itString = _arrayStrings.Begin();
            _itStringOp = _arrayStrings.Begin();
        }

        [Benchmark]
        public void Array_1_Integer_Iterator()
        {
            while (_itInt.Next()) { }
        }

        [Benchmark]
        public void Array_1_Integer_Iterator_OperatorOverload()
        {
            while (_itIntOp++) { }
        }

        [Benchmark]
        public void Array_1_Integer_Enumerator()
        {
            foreach (var i in _arrayInts) { }
        }

        [Benchmark]
        public void Array_1_String_Iterator()
        {
            while (_itString.Next()) { }
        }

        [Benchmark]
        public void Array_1_String_Iterator_OperatorOverload()
        {
            while (_itStringOp++) { }
        }

        [Benchmark]
        public void Array_1_String_Enumerator()
        {
            foreach (var s in _arrayStrings) { }
        }
    }
}
