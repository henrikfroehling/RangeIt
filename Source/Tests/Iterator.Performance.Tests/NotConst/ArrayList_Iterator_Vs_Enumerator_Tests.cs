namespace Iterator.Performance.Tests.NotConst
{
    using BenchmarkDotNet.Attributes;
    using BenchmarkDotNet.Attributes.Columns;
    using RangeIt.Iterators;
    using System;
    using System.Collections;

    [MinColumn, MaxColumn]
    public class ArrayList_Iterator_Vs_Enumerator_Tests
    {
        private readonly ArrayList _arrayListInts = new ArrayList();
        private readonly ArrayList _arrayListStrings = new ArrayList();

        private Iterator _itInt;
        private Iterator _itIntOp;
        private Iterator _itString;
        private Iterator _itStringOp;

        [Setup]
        public void Setup()
        {
            var rnd = new Random();
            var max = Constants.MAX_ITEMS;

            for (int i = 0; i < max; i++)
                _arrayListInts.Add(rnd.Next(max));

            for (int i = 0; i < max; i++)
                _arrayListStrings.Add(rnd.Next(max).ToString());

            _itInt = _arrayListInts.Begin();
            _itIntOp = _arrayListInts.Begin();

            _itString = _arrayListStrings.Begin();
            _itStringOp = _arrayListStrings.Begin();
        }

        [Benchmark]
        public void ArrayList_Integer_Iterator()
        {
            while (_itInt.Next()) { }
        }

        [Benchmark]
        public void ArrayList_Integer_Iterator_OperatorOverload()
        {
            while (_itIntOp++) { }
        }

        [Benchmark]
        public void ArrayList_Integer_Enumerator()
        {
            foreach (var i in _arrayListInts) { }
        }

        [Benchmark]
        public void ArrayList_String_Iterator()
        {
            while (_itString.Next()) { }
        }

        [Benchmark]
        public void ArrayList_String_Iterator_OperatorOverload()
        {
            while (_itStringOp++) { }
        }

        [Benchmark]
        public void ArrayList_String_Enumerator()
        {
            foreach (var s in _arrayListStrings) { }
        }
    }
}
