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

        [Setup]
        public void Setup()
        {
            var rnd = new Random();
            var max = Constants.MAX_ITEMS;

            for (int i = 0; i < max; i++)
                _collectionInts.Add(rnd.Next(max));

            for (int i = 0; i < max; i++)
                _collectionStrings.Add(rnd.Next(max).ToString());
        }

        [Benchmark]
        public void Collection_1_Integer_Iterator()
        {
            var it = _collectionInts.Begin();
            while (it.Next()) { }
        }

        [Benchmark]
        public void Collection_1_Integer_Iterator_OperatorOverload()
        {
            var it = _collectionInts.Begin();
            while (it++) { }
        }

        [Benchmark]
        public void Collection_1_Integer_Enumerator()
        {
            foreach (var i in _collectionInts) { }
        }

        [Benchmark]
        public void Collection_1_String_Iterator()
        {
            var it = _collectionStrings.Begin();
            while (it.Next()) { }
        }

        [Benchmark]
        public void Collection_1_String_Iterator_OperatorOverload()
        {
            var it = _collectionStrings.Begin();
            while (it++) { }
        }

        [Benchmark]
        public void Collection_1_String_Enumerator()
        {
            foreach (var s in _collectionStrings) { }
        }
    }
}
