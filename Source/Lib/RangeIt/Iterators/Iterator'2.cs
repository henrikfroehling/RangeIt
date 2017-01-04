namespace RangeIt.Iterators
{
    using Detail.NotConst;
    using Interfaces;
    using System.Collections;
    using System.Collections.Concurrent;
    using System.Collections.Generic;

    public struct Iterator<T, U> : IIterator<T, U>
    {
        private IIterator<T, U> _iteratorHelper;

        public Iterator(KeyValuePair<T, U>[] items)
        {
            _iteratorHelper = new ArrayIterator<T, U>(items);
        }

        internal Iterator(KeyValuePair<T, U>[] items, bool isEnd)
        {
            _iteratorHelper = new ArrayIterator<T, U>(items, isEnd);
        }

        public Iterator(Dictionary<T, U> dictionary)
        {
            _iteratorHelper = new DictionaryIterator<T, U>(dictionary);
        }

        internal Iterator(Dictionary<T, U> dictionary, bool isEnd)
        {
            _iteratorHelper = new DictionaryIterator<T, U>(dictionary, isEnd);
        }

        public Iterator(ConcurrentDictionary<T, U> dictionary)
        {
            _iteratorHelper = new ConcurrentDictionaryIterator<T, U>(dictionary);
        }

        internal Iterator(ConcurrentDictionary<T, U> dictionary, bool isEnd)
        {
            _iteratorHelper = new ConcurrentDictionaryIterator<T, U>(dictionary, isEnd);
        }

        public KeyValuePair<T, U> Current
        {
            get { return _iteratorHelper.Current; }
            set { _iteratorHelper.Current = value; }
        }

        public T Key => _iteratorHelper.Key;

        public U Value => _iteratorHelper.Value;

        public int Index => _iteratorHelper.Index;

        public bool IsEndIterator => _iteratorHelper.IsEndIterator;

        public bool IsValid => _iteratorHelper.IsValid;

        public bool Previous() => _iteratorHelper.Previous();

        public bool Next() => _iteratorHelper.Next();

        public IEnumerator<KeyValuePair<T, U>> GetEnumerator() => _iteratorHelper.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        public override string ToString() => Current.ToString();

        public static Iterator<T, U> operator --(Iterator<T, U> it)
        {
            it.Previous();
            return it;
        }

        public static Iterator<T, U> operator ++(Iterator<T, U> it)
        {
            it.Next();
            return it;
        }

        public static implicit operator bool(Iterator<T, U> it) => it.IsValid;

        public static explicit operator KeyValuePair<T, U>(Iterator<T, U> it) => it.Current;
    }
}
