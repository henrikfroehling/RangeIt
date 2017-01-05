namespace Iterator.Performance.Tests.Const
{
    using BenchmarkDotNet.Attributes;
    using BenchmarkDotNet.Attributes.Columns;
    using RangeIt.Iterators;
    using System;
    using System.Collections.Generic;

    [MinColumn, MaxColumn]
    public class List_1_ConstIterator_Vs_Enumerator_Tests
    {
        private readonly List<int> _listInts = new List<int>();
        private readonly List<string> _listStrings = new List<string>();

        private ConstIterator<int> _itInt;
        private ConstIterator<int> _itIntOp;
        private ConstIterator<string> _itString;
        private ConstIterator<string> _itStringOp;

        [Setup]
        public void Setup()
        {
            var rnd = new Random();
            var max = Constants.MAX_ITEMS;

            for (int i = 0; i < max; i++)
                _listInts.Add(rnd.Next(max));

            for (int i = 0; i < max; i++)
                _listStrings.Add(rnd.Next(max).ToString());

            _itInt = _listInts.ConstBegin();
            _itIntOp = _listInts.ConstBegin();

            _itString = _listStrings.ConstBegin();
            _itStringOp = _listStrings.ConstBegin();
        }

        [Benchmark]
        public void List_1_Integer_ConstIterator()
        {
            while (_itInt.Next()) { }
        }

        [Benchmark]
        public void List_1_Integer_ConstIterator_OperatorOverload()
        {
            while (_itIntOp++) { }
        }

        [Benchmark]
        public void List_1_Integer_Enumerator()
        {
            foreach (var i in _listInts) { }
        }

        [Benchmark]
        public void List_1_String_ConstIterator()
        {
            while (_itString.Next()) { }
        }

        [Benchmark]
        public void List_1_String_ConstIterator_OperatorOverload()
        {
            while (_itStringOp++) { }
        }

        [Benchmark]
        public void List_1_String_Enumerator()
        {
            foreach (var s in _listStrings) { }
        }
    }
}
