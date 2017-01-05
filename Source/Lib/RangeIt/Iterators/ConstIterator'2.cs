﻿namespace RangeIt.Iterators
{
    using Adapters.Const;
    using Interfaces;
    using Interfaces.Adapters;
    using System.Collections;
    using System.Collections.Concurrent;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public struct ConstIterator<T, U> : IConstIterator<T, U>, IIterable, IEnumerable<KeyValuePair<T, U>>
    {
        private IConstIteratorAdapter<T, U> _iteratorAdapter;

        public ConstIterator(KeyValuePair<T, U>[] items)
        {
            _iteratorAdapter = new ArrayConstIteratorAdapter<T, U>(items);
        }

        internal ConstIterator(KeyValuePair<T, U>[] items, bool isEnd)
        {
            _iteratorAdapter = new ArrayConstIteratorAdapter<T, U>(items, isEnd);
        }

        public ConstIterator(Dictionary<T, U> dictionary)
        {
            _iteratorAdapter = new DictionaryConstIteratorAdapter<T, U>(dictionary);
        }

        internal ConstIterator(Dictionary<T, U> dictionary, bool isEnd)
        {
            _iteratorAdapter = new DictionaryConstIteratorAdapter<T, U>(dictionary, isEnd);
        }

        public ConstIterator(ReadOnlyDictionary<T, U> dictionary)
        {
            _iteratorAdapter = new ReadOnlyDictionaryConstIteratorAdapter<T, U>(dictionary);
        }

        internal ConstIterator(ReadOnlyDictionary<T, U> dictionary, bool isEnd)
        {
            _iteratorAdapter = new ReadOnlyDictionaryConstIteratorAdapter<T, U>(dictionary, isEnd);
        }

        public ConstIterator(ConcurrentDictionary<T, U> dictionary)
        {
            _iteratorAdapter = new ConcurrentDictionaryConstIteratorAdapter<T, U>(dictionary);
        }

        internal ConstIterator(ConcurrentDictionary<T, U> dictionary, bool isEnd)
        {
            _iteratorAdapter = new ConcurrentDictionaryConstIteratorAdapter<T, U>(dictionary, isEnd);
        }

        public KeyValuePair<T, U> Current => _iteratorAdapter.Current;

        public T Key => _iteratorAdapter.Key;

        public U Value => _iteratorAdapter.Value;

        public int Index => _iteratorAdapter.Index;

        public bool IsEndIterator => _iteratorAdapter.IsEndIterator;

        public bool IsValid => _iteratorAdapter.IsValid;

        public bool Previous() => _iteratorAdapter.Previous();

        public bool Next() => _iteratorAdapter.Next();

        public IEnumerator<KeyValuePair<T, U>> GetEnumerator() => _iteratorAdapter.GetEnumerator();

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

        public static ConstIterator<T, U> operator -(ConstIterator<T, U> it, int count)
        {
            for (int i = count; i > 0; --i)
            {
                if (!it.Previous())
                    break;
            }

            return it;
        }

        public static ConstIterator<T, U> operator +(ConstIterator<T, U> it, int count)
        {
            for (int i = 0; i < count; ++i)
            {
                if (!it.Next())
                    break;
            }

            return it;
        }

        public static implicit operator bool(ConstIterator<T, U> it) => it.IsValid;

        public static explicit operator KeyValuePair<T, U>(ConstIterator<T, U> it) => it.Current;
    }
}
