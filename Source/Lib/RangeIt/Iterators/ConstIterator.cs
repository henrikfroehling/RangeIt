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
            _iteratorAdapter = new SortedListConstIteratorAdapter(sortedList);
        }

        internal ConstIterator(SortedList sortedList, bool isEnd)
        {
            _iteratorAdapter = new SortedListConstIteratorAdapter(sortedList, isEnd);
        }

        public object Current => _iteratorAdapter.Current;

        public int Index => _iteratorAdapter.Index;

        public bool IsEndIterator => _iteratorAdapter.IsEndIterator;

        public bool IsValid => _iteratorAdapter.IsValid;

        public bool Previous() => _iteratorAdapter.Previous();

        public bool Next() => _iteratorAdapter.Next();

        public IEnumerator GetEnumerator() => _iteratorAdapter.GetEnumerator();

        public override string ToString() => Current?.ToString();

        public static ConstIterator operator --(ConstIterator it)
        {
            it.Previous();
            return it;
        }

        public static ConstIterator operator ++(ConstIterator it)
        {
            it.Next();
            return it;
        }

        public static implicit operator bool(ConstIterator it) => it.IsValid;
    }
}
