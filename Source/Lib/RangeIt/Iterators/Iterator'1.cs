namespace RangeIt.Iterators
{
    using Adapters.NotConst;
    using Interfaces;
    using Interfaces.Adapters;
    using System.Collections;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public struct Iterator<T> : IIterator<T>, IIterable, IEnumerable<T>
    {
        private IIteratorAdapter<T> _iteratorAdapter;

        public Iterator(T[] items)
        {
            _iteratorAdapter = new ArrayIteratorAdapter<T>(items);
        }

        internal Iterator(T[] items, bool isEnd)
        {
            _iteratorAdapter = new ArrayIteratorAdapter<T>(items, isEnd);
        }

        public Iterator(List<T> list)
        {
            _iteratorAdapter = new ListIteratorAdapter<T>(list);
        }

        internal Iterator(List<T> list, bool isEnd)
        {
            _iteratorAdapter = new ListIteratorAdapter<T>(list, isEnd);
        }

        public Iterator(Collection<T> collection)
        {
            _iteratorAdapter = null;
        }

        internal Iterator(Collection<T> collection, bool isEnd)
        {
            _iteratorAdapter = null;
        }

        public T Current
        {
            get { return _iteratorAdapter.Current; }
            set { _iteratorAdapter.Current = value; }
        }

        public int Index => _iteratorAdapter.Index;

        public bool IsEndIterator => _iteratorAdapter.IsEndIterator;

        public bool IsValid => _iteratorAdapter.IsValid;

        public bool Previous() => _iteratorAdapter.Previous();

        public bool Next() => _iteratorAdapter.Next();

        public IEnumerator<T> GetEnumerator() => _iteratorAdapter.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
