namespace RangeIt.Iterators
{
    using Interfaces;
    using Interfaces.Adapters;
    using System.Collections;
    using System.Collections.Concurrent;
    using System.Collections.Generic;

    public struct Iterator<T, U> : IIterator<T, U>, IIterable, IEnumerable<KeyValuePair<T, U>>
    {
        private IIteratorAdapter<T, U> _iteratorAdapter;

        public Iterator(KeyValuePair<T, U>[] items)
        {
            _iteratorAdapter = null;
        }

        internal Iterator(KeyValuePair<T, U>[] items, bool isEnd)
        {
            _iteratorAdapter = null;
        }

        public Iterator(Dictionary<T, U> dictionary)
        {
            _iteratorAdapter = null;
        }

        internal Iterator(Dictionary<T, U> dictionary, bool isEnd)
        {
            _iteratorAdapter = null;
        }

        public Iterator(ConcurrentDictionary<T, U> dictionary)
        {
            _iteratorAdapter = null;
        }

        internal Iterator(ConcurrentDictionary<T, U> dictionary, bool isEnd)
        {
            _iteratorAdapter = null;
        }

        public KeyValuePair<T, U> Current
        {
            get { return _iteratorAdapter.Current; }
            set { _iteratorAdapter.Current = value; }
        }

        public T Key => _iteratorAdapter.Key;

        public U Value => _iteratorAdapter.Value;

        public int Index => _iteratorAdapter.Index;

        public bool IsEndIterator => _iteratorAdapter.IsEndIterator;

        public bool IsValid => _iteratorAdapter.IsValid;

        public bool Previous() => _iteratorAdapter.Previous();

        public bool Next() => _iteratorAdapter.Next();

        public IEnumerator<KeyValuePair<T, U>> GetEnumerator() => _iteratorAdapter.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
