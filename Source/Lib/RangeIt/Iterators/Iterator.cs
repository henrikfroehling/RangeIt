namespace RangeIt.Iterators
{
    using Interfaces;
    using Interfaces.Adapters;
    using System.Collections;

    public struct Iterator : IIterator, IIterable, IEnumerable
    {
        private IIteratorAdapter _iteratorAdapter;

        public Iterator(ArrayList arrayList)
        {
            _iteratorAdapter = null;
        }

        internal Iterator(ArrayList arrayList, bool isEnd)
        {
            _iteratorAdapter = null;
        }

        public Iterator(SortedList sortedList)
        {
            _iteratorAdapter = null;
        }

        internal Iterator(SortedList sortedList, bool isEnd)
        {
            _iteratorAdapter = null;
        }

        public object Current
        {
            get { return _iteratorAdapter.Current; }
            set { _iteratorAdapter.Current = value; }
        }

        public int Index => _iteratorAdapter.Index;

        public bool IsEndIterator => _iteratorAdapter.IsEndIterator;

        public bool IsValid => _iteratorAdapter.IsValid;

        public bool Previous() => _iteratorAdapter.Previous();

        public bool Next() => _iteratorAdapter.Next();

        public IEnumerator GetEnumerator() => _iteratorAdapter.GetEnumerator();
    }
}
