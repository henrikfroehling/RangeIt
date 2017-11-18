namespace Iterator.Performance.Tests.Const
{
    using BenchmarkDotNet.Attributes;
    using BenchmarkDotNet.Attributes.Columns;
    using RangeIt.Iterators;
    using System;
    using System.Collections.Generic;

    [MinColumn, MaxColumn]
    public class Array_2_ConstIterator_Vs_Enumerator_Tests
    {
        private readonly KeyValuePair<int, int>[] _arrayInts = new KeyValuePair<int, int>[Constants.MAX_ITEMS];
        private readonly KeyValuePair<string, string>[] _arrayStrings = new KeyValuePair<string, string>[Constants.MAX_ITEMS];

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
                _arrayInts[i] = new KeyValuePair<int, int>(value, value);
            }

            for (int i = 0; i < max; i++)
            {
                string value = rnd.Next(max).ToString();
                _arrayStrings[i] = new KeyValuePair<string, string>(value, value);
            }

            _itInt = _arrayInts.ConstBegin();
            _itIntOp = _arrayInts.ConstBegin();

            _itString = _arrayStrings.ConstBegin();
            _itStringOp = _arrayStrings.ConstBegin();
        }

        [Benchmark]
        public void Array_2_Integer_ConstIterator()
        {
            while (_itInt.Next()) { }
        }

        [Benchmark]
        public void Array_2_Integer_ConstIterator_OperatorOverload()
        {
            while (_itIntOp++) { }
        }

        [Benchmark]
        public void Array_2_Integer_Enumerator()
        {
            foreach (KeyValuePair<int, int> i in _arrayInts) { }
        }

        [Benchmark]
        public void Array_2_String_ConstIterator()
        {
            while (_itString.Next()) { }
        }

        [Benchmark]
        public void Array_2_String_ConstIterator_OperatorOverload()
        {
            while (_itStringOp++) { }
        }

        [Benchmark]
        public void Array_2_String_Enumerator()
        {
            foreach (KeyValuePair<string, string> s in _arrayStrings) { }
        }
    }
}
