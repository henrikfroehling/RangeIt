namespace Iterator.Performance.Tests.Const
{
    using BenchmarkDotNet.Attributes;
    using BenchmarkDotNet.Attributes.Columns;
    using RangeIt.Iterators;
    using System;
    using System.Collections.ObjectModel;

    [MinColumn, MaxColumn]
    public class Collection_1_ConstIterator_Vs_Enumerator_Tests
    {
        private readonly Collection<int> _collectionInts = new Collection<int>();
        private readonly Collection<string> _collectionStrings = new Collection<string>();

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
                _collectionInts.Add(rnd.Next(max));

            for (int i = 0; i < max; i++)
                _collectionStrings.Add(rnd.Next(max).ToString());

            _itInt = _collectionInts.ConstBegin();
            _itIntOp = _collectionInts.ConstBegin();

            _itString = _collectionStrings.ConstBegin();
            _itStringOp = _collectionStrings.ConstBegin();
        }

        [Benchmark]
        public void Collection_1_Integer_ConstIterator()
        {
            while (_itInt.Next()) { }
        }

        [Benchmark]
        public void Collection_1_Integer_ConstIterator_OperatorOverload()
        {
            while (_itIntOp++) { }
        }

        [Benchmark]
        public void Collection_1_Integer_Enumerator()
        {
            foreach (int i in _collectionInts) { }
        }

        [Benchmark]
        public void Collection_1_String_ConstIterator()
        {
            while (_itString.Next()) { }
        }

        [Benchmark]
        public void Collection_1_String_ConstIterator_OperatorOverload()
        {
            while (_itStringOp++) { }
        }

        [Benchmark]
        public void Collection_1_String_Enumerator()
        {
            foreach (string s in _collectionStrings) { }
        }
    }
}
