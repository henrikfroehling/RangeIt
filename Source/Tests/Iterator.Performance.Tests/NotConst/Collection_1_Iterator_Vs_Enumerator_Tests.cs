namespace Iterator.Performance.Tests.NotConst
{
    using BenchmarkDotNet.Attributes;
    using BenchmarkDotNet.Attributes.Columns;
    using RangeIt.Iterators;
    using System;
    using System.Collections.ObjectModel;

    [MinColumn, MaxColumn]
    public class Collection_1_Iterator_Vs_Enumerator_Tests
    {
        private readonly Collection<int> _collectionInts = new Collection<int>();
        private readonly Collection<string> _collectionStrings = new Collection<string>();

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
                _collectionInts.Add(rnd.Next(max));

            for (int i = 0; i < max; i++)
                _collectionStrings.Add(rnd.Next(max).ToString());

            _itInt = _collectionInts.Begin();
            _itIntOp = _collectionInts.Begin();

            _itString = _collectionStrings.Begin();
            _itStringOp = _collectionStrings.Begin();
        }

        [Benchmark]
        public void Collection_1_Integer_Iterator()
        {
            while (_itInt.Next()) { }
        }

        [Benchmark]
        public void Collection_1_Integer_Iterator_OperatorOverload()
        {
            while (_itIntOp++) { }
        }

        [Benchmark]
        public void Collection_1_Integer_Enumerator()
        {
            foreach (var i in _collectionInts) { }
        }

        [Benchmark]
        public void Collection_1_String_Iterator()
        {
            while (_itString.Next()) { }
        }

        [Benchmark]
        public void Collection_1_String_Iterator_OperatorOverload()
        {
            while (_itStringOp++) { }
        }

        [Benchmark]
        public void Collection_1_String_Enumerator()
        {
            foreach (var s in _collectionStrings) { }
        }
    }
}
