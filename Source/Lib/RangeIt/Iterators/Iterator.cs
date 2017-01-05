namespace RangeIt.Iterators
{
    using Adapters.NotConst;
    using Interfaces;
    using Interfaces.Adapters;
    using System.Collections;

    public struct Iterator : IIterator, IIterable, IEnumerable
    {
        private IIteratorAdapter _iteratorAdapter;

        public Iterator(ArrayList arrayList)
        {
            _iteratorAdapter = new ArrayListIteratorAdapter(arrayList);
        }

        internal Iterator(ArrayList arrayList, bool isEnd)
        {
            _iteratorAdapter = new ArrayListIteratorAdapter(arrayList, isEnd);
        }

        public Iterator(SortedList sortedList)
        {
            _iteratorAdapter = new SortedListIteratorAdapter(sortedList);
        }

        internal Iterator(SortedList sortedList, bool isEnd)
        {
            _iteratorAdapter = new SortedListIteratorAdapter(sortedList, isEnd);
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

        public override string ToString() => Current?.ToString();

        public static Iterator operator --(Iterator it)
        {
            it.Previous();
            return it;
        }

        public static Iterator operator ++(Iterator it)
        {
            it.Next();
            return it;
        }

        public static implicit operator bool(Iterator it) => it.IsValid;
    }
}
