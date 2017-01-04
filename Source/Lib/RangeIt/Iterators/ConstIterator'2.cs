namespace RangeIt.Iterators
{
    using Detail.Const;
    using Interfaces;
    using System.Collections;
    using System.Collections.Concurrent;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public struct ConstIterator<T, U> : IConstIterator<T, U>
    {
        private IConstIterator<T, U> _iteratorHelper;

        public ConstIterator(KeyValuePair<T, U>[] items)
        {
            _iteratorHelper = new ArrayConstIterator<T, U>(items);
        }

        internal ConstIterator(KeyValuePair<T, U>[] items, bool isEnd)
        {
            _iteratorHelper = new ArrayConstIterator<T, U>(items, isEnd);
        }

        public ConstIterator(Dictionary<T, U> dictionary)
        {
            _iteratorHelper = new DictionaryConstIterator<T, U>(dictionary);
        }

        internal ConstIterator(Dictionary<T, U> dictionary, bool isEnd)
        {
            _iteratorHelper = new DictionaryConstIterator<T, U>(dictionary, isEnd);
        }

        public ConstIterator(ReadOnlyDictionary<T, U> dictionary)
        {
            _iteratorHelper = new ReadOnlyDictionaryConstIterator<T, U>(dictionary);
        }

        internal ConstIterator(ReadOnlyDictionary<T, U> dictionary, bool isEnd)
        {
            _iteratorHelper = new ReadOnlyDictionaryConstIterator<T, U>(dictionary, isEnd);
        }

        public ConstIterator(ConcurrentDictionary<T, U> dictionary)
        {
            _iteratorHelper = new ConcurrentDictionaryConstIterator<T, U>(dictionary);
        }

        internal ConstIterator(ConcurrentDictionary<T, U> dictionary, bool isEnd)
        {
            _iteratorHelper = new ConcurrentDictionaryConstIterator<T, U>(dictionary, isEnd);
        }

        public KeyValuePair<T, U> Current => _iteratorHelper.Current;

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

        public static ConstIterator<T, U> operator --(ConstIterator<T, U> it)
        {
            it.Previous();
            return it;
        }

        public static ConstIterator<T, U> operator ++(ConstIterator<T, U> it)
        {
            it.Next();
            return it;
        }

        public static implicit operator bool(ConstIterator<T, U> it) => it.IsValid;

        public static explicit operator KeyValuePair<T, U>(ConstIterator<T, U> it) => it.Current;
    }
}
