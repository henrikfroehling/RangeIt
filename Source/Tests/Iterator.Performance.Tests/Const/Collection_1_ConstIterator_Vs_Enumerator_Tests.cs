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
        private readonly Random _random = new Random();

        [Setup]
        public void Setup()
        {
            var max = Constants.MAX_ITEMS;

            for (int i = 0; i < max; i++)
                _collectionInts.Add(_random.Next(max));

            for (int i = 0; i < max; i++)
                _collectionStrings.Add(_random.Next(max).ToString());
        }

        [Benchmark]
        public void Collection_1_Integer_ConstIterator()
        {
            var it = _collectionInts.ConstBegin();
            while (it++) { }
        }

        [Benchmark]
        public void Collection_1_Integer_Enumerator()
        {
            foreach (var i in _collectionInts) { }
        }

        [Benchmark]
        public void Collection_1_String_ConstIterator()
        {
            var it = _collectionStrings.ConstBegin();
            while (it++) { }
        }

        [Benchmark]
        public void Collection_1_String_Enumerator()
        {
            foreach (var s in _collectionStrings) { }
        }
    }
}
