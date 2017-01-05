namespace RangeIt.Iterators
{
    using Adapters.NotConst;
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
            _iteratorAdapter = new ArrayIteratorAdapter<T, U>(items);
        }

        internal Iterator(KeyValuePair<T, U>[] items, bool isEnd)
        {
            _iteratorAdapter = new ArrayIteratorAdapter<T, U>(items, isEnd);
        }

        public Iterator(Dictionary<T, U> dictionary)
        {
            _iteratorAdapter = new DictionaryIteratorAdapter<T, U>(dictionary);
        }

        internal Iterator(Dictionary<T, U> dictionary, bool isEnd)
        {
            _iteratorAdapter = new DictionaryIteratorAdapter<T, U>(dictionary, isEnd);
        }

        public Iterator(ConcurrentDictionary<T, U> dictionary)
        {
            _iteratorAdapter = new ConcurrentDictionaryIteratorAdapter<T, U>(dictionary);
        }

        internal Iterator(ConcurrentDictionary<T, U> dictionary, bool isEnd)
        {
            _iteratorAdapter = new ConcurrentDictionaryIteratorAdapter<T, U>(dictionary, isEnd);
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
