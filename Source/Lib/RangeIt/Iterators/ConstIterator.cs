namespace RangeIt.Iterators
{
    using Detail.Const;
    using Interfaces;
    using System.Collections;

    public struct ConstIterator : IConstIterator
    {
        private IConstIterator _iteratorHelper;

        public ConstIterator(ArrayList arrayList)
        {
            _iteratorHelper = new ArrayListConstIterator(arrayList);
        }

        internal ConstIterator(ArrayList arrayList, bool isEnd)
        {
            _iteratorHelper = new ArrayListConstIterator(arrayList, isEnd);
        }

        public ConstIterator(SortedList sortedList)
        {
            _iteratorHelper = new SortedListConstIterator(sortedList);
        }

        internal ConstIterator(SortedList sortedList, bool isEnd)
        {
            _iteratorHelper = new SortedListConstIterator(sortedList, isEnd);
        }

        public object Current => _iteratorHelper.Current;

        public int Index => _iteratorHelper.Index;

        public bool IsEndIterator => _iteratorHelper.IsEndIterator;

        public bool IsValid => _iteratorHelper.IsValid;

        public bool Previous() => _iteratorHelper.Previous();

        public bool Next() => _iteratorHelper.Next();

        public IEnumerator GetEnumerator() => _iteratorHelper.GetEnumerator();

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
