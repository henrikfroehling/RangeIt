namespace Iterator.Performance.Tests.NotConst
{
    using BenchmarkDotNet.Attributes;
    using RangeIt.Iterators;
    using System;
    using System.Collections;

    public class ArrayList_Iterator_Vs_Enumerator_Tests
    {
        private readonly ArrayList _arrayListInts = new ArrayList();
        private readonly ArrayList _arrayListStrings = new ArrayList();
        private readonly Random _random = new Random();

        public ArrayList_Iterator_Vs_Enumerator_Tests()
        {
            var max = Constants.MAX_ITEMS;

            for (int i = 0; i < max; i++)
                _arrayListInts.Add(_random.Next(max));

            for (int i = 0; i < max; i++)
                _arrayListStrings.Add(_random.Next(max).ToString());
        }

        [Benchmark]
        public void ArrayList_Integer_Iteration()
        {
            var it = _arrayListInts.Begin();
            while (it++) { }
        }

        [Benchmark]
        public void ArrayList_Integer_Enumerration()
        {
            foreach (var i in _arrayListInts) { }
        }

        [Benchmark]
        public void ArrayList_String_Iteration()
        {
            var it = _arrayListStrings.Begin();
            while (it++) { }
        }

        [Benchmark]
        public void ArrayList_String_Enumerration()
        {
            foreach (var s in _arrayListStrings) { }
        }
    }
}
