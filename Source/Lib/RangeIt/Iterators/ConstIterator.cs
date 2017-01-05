namespace RangeIt.Iterators
{
    using Adapters.Const;
    using Interfaces;
    using Interfaces.Adapters;
    using System.Collections;

    public struct ConstIterator : IConstIterator, IIterable, IEnumerable
    {
        private IConstIteratorAdapter _iteratorAdapter;

        public ConstIterator(ArrayList arrayList)
        {
            _iteratorAdapter = new ArrayListConstIteratorAdapter(arrayList);
        }

        internal ConstIterator(ArrayList arrayList, bool isEnd)
        {
            _iteratorAdapter = new ArrayListConstIteratorAdapter(arrayList, isEnd);
        }

        public ConstIterator(SortedList sortedList)
        {
            _iteratorAdapter = null;
        }

        internal ConstIterator(SortedList sortedList, bool isEnd)
        {
            _iteratorAdapter = null;
        }

        public object Current => _iteratorAdapter.Current;

        public int Index => _iteratorAdapter.Index;

        public bool IsEndIterator => _iteratorAdapter.IsEndIterator;

        public bool IsValid => _iteratorAdapter.IsValid;

        public bool Previous() => _iteratorAdapter.Previous();

        public bool Next() => _iteratorAdapter.Next();

        public IEnumerator GetEnumerator() => _iteratorAdapter.GetEnumerator();
    }
}
