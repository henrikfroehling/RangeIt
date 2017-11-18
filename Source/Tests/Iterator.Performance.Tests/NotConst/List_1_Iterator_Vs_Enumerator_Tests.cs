namespace Iterator.Performance.Tests.NotConst
{
    using BenchmarkDotNet.Attributes;
    using BenchmarkDotNet.Attributes.Columns;
    using RangeIt.Iterators;
    using System;
    using System.Collections.Generic;

    [MinColumn, MaxColumn]
    public class List_1_Iterator_Vs_Enumerator_Tests
    {
        private readonly List<int> _listInts = new List<int>();
        private readonly List<string> _listStrings = new List<string>();

        private Iterator<int> _itInt;
        private Iterator<int> _itIntOp;
        private Iterator<string> _itString;
        private Iterator<string> _itStringOp;

        [GlobalSetup]
        public void Setup()
        {
            var rnd = new Random();
            const int max = Constants.MAX_ITEMS;

            for (int i = 0; i < max; i++)
                _listInts.Add(rnd.Next(max));

            for (int i = 0; i < max; i++)
                _listStrings.Add(rnd.Next(max).ToString());

            _itInt = _listInts.Begin();
            _itIntOp = _listInts.Begin();

            _itString = _listStrings.Begin();
            _itStringOp = _listStrings.Begin();
        }

        [Benchmark]
        public void List_1_Integer_Iterator()
        {
            while (_itInt.Next()) { }
        }

        [Benchmark]
        public void List_1_Integer_Iterator_OperatorOverload()
        {
            while (_itIntOp++) { }
        }

        [Benchmark]
        public void List_1_Integer_Enumerator()
        {
            foreach (int i in _listInts) { }
        }

        [Benchmark]
        public void List_1_String_Iterator()
        {
            while (_itString.Next()) { }
        }

        [Benchmark]
        public void List_1_String_Iterator_OperatorOverload()
        {
            while (_itStringOp++) { }
        }

        [Benchmark]
        public void List_1_String_Enumerator()
        {
            foreach (string s in _listStrings) { }
        }
    }
}
