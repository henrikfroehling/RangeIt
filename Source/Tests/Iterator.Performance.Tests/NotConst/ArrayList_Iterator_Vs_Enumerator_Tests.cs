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
        private readonly Random _random = new Random();

        [Setup]
        public void Setup()
        {
            var max = Constants.MAX_ITEMS;

            for (int i = 0; i < max; i++)
                _arrayListInts.Add(_random.Next(max));

            for (int i = 0; i < max; i++)
                _arrayListStrings.Add(_random.Next(max).ToString());
        }

        [Benchmark]
        public void ArrayList_Integer_Iterator()
        {
            var it = _arrayListInts.Begin();
            while (it++) { }
        }

        [Benchmark]
        public void ArrayList_Integer_Enumerator()
        {
            foreach (var i in _arrayListInts) { }
        }

        [Benchmark]
        public void ArrayList_String_Iterator()
        {
            var it = _arrayListStrings.Begin();
            while (it++) { }
        }

        [Benchmark]
        public void ArrayList_String_Enumerator()
        {
            foreach (var s in _arrayListStrings) { }
        }
    }
}
