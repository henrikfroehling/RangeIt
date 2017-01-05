namespace Iterator.Performance.Tests.Const
{
    using BenchmarkDotNet.Attributes;
    using BenchmarkDotNet.Attributes.Columns;
    using RangeIt.Iterators;
    using System;
    using System.Collections.ObjectModel;

    [MinColumn, MaxColumn]
    public class ReadOnlyCollection_1_ConstIterator_Vs_Enumerator_Tests
    {
        private readonly Collection<int> _collectionInts = new Collection<int>();
        private readonly Collection<string> _collectionStrings = new Collection<string>();

        private ReadOnlyCollection<int> _readOnlyCollectionInts;
        private ReadOnlyCollection<string> _readOnlyCollectionStrings;

        [Setup]
        public void Setup()
        {
            var rnd = new Random();
            var max = Constants.MAX_ITEMS;

            for (int i = 0; i < max; i++)
                _collectionInts.Add(rnd.Next(max));

            for (int i = 0; i < max; i++)
                _collectionStrings.Add(rnd.Next(max).ToString());

            _readOnlyCollectionInts = new ReadOnlyCollection<int>(_collectionInts);
            _readOnlyCollectionStrings = new ReadOnlyCollection<string>(_collectionStrings);
        }

        [Benchmark]
        public void ReadOnlyCollection_1_Integer_ConstIterator()
        {
            var it = _readOnlyCollectionInts.ConstBegin();
            while (it.Next()) { }
        }

        [Benchmark]
        public void ReadOnlyCollection_1_Integer_ConstIterator_OperatorOverload()
        {
            var it = _readOnlyCollectionInts.ConstBegin();
            while (it++) { }
        }

        [Benchmark]
        public void ReadOnlyCollection_1_Integer_Enumerator()
        {
            foreach (var i in _readOnlyCollectionInts) { }
        }

        [Benchmark]
        public void ReadOnlyCollection_1_String_ConstIterator()
        {
            var it = _readOnlyCollectionStrings.ConstBegin();
            while (it.Next()) { }
        }

        [Benchmark]
        public void ReadOnlyCollection_1_String_ConstIterator_OperatorOverload()
        {
            var it = _readOnlyCollectionStrings.ConstBegin();
            while (it++) { }
        }

        [Benchmark]
        public void ReadOnlyCollection_1_String_Enumerator()
        {
            foreach (var s in _readOnlyCollectionStrings) { }
        }
    }
}
