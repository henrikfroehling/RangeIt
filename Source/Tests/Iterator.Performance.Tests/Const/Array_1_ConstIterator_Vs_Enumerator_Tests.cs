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

        private ConstIterator<int> _itInt;
        private ConstIterator<int> _itIntOp;
        private ConstIterator<string> _itString;
        private ConstIterator<string> _itStringOp;

        [GlobalSetup]
        public void Setup()
        {
            var rnd = new Random();
            const int max = Constants.MAX_ITEMS;

            for (int i = 0; i < max; i++)
                _arrayInts[i] = rnd.Next(max);

            for (int i = 0; i < max; i++)
                _arrayStrings[i] = rnd.Next(max).ToString();

            _itInt = _arrayInts.ConstBegin();
            _itIntOp = _arrayInts.ConstBegin();

            _itString = _arrayStrings.ConstBegin();
            _itStringOp = _arrayStrings.ConstBegin();
        }

        [Benchmark]
        public void Array_1_Integer_ConstIterator()
        {
            while (_itInt.Next()) { }
        }

        [Benchmark]
        public void Array_1_Integer_ConstIterator_OperatorOverload()
        {
            while (_itIntOp++) { }
        }

        [Benchmark]
        public void Array_1_Integer_Enumerator()
        {
            foreach (int i in _arrayInts) { }
        }

        [Benchmark]
        public void Array_1_String_ConstIterator()
        {
            while (_itString.Next()) { }
        }

        [Benchmark]
        public void Array_1_String_ConstIterator_OperatorOverload()
        {
            while (_itStringOp++) { }
        }

        [Benchmark]
        public void Array_1_String_Enumerator()
        {
            foreach (string s in _arrayStrings) { }
        }
    }
}
