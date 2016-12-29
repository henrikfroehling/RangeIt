﻿namespace RangeIt.Iterators
{
    using Detail.Const;
    using Interfaces;
    using System.Collections;
    using System.Collections.Concurrent;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public sealed class ConstIterator<T, U> : IConstIterator<T, U>
    {
        private IConstIterator<T, U> _iteratorHelper;

        private ConstIterator() { }

        public ConstIterator(KeyValuePair<T, U>[] items)
        {
            _iteratorHelper = new ArrayConstIteratorHelper<T, U>(items);
        }

        public ConstIterator(Dictionary<T, U> dictionary)
        {
            _iteratorHelper = new DictionaryConstIteratorHelper<T, U>(dictionary);
        }

        public ConstIterator(ReadOnlyDictionary<T, U> dictionary)
        {
            _iteratorHelper = new ReadOnlyDictionaryConstIteratorHelper<T, U>(dictionary);
        }

        public ConstIterator(ConcurrentDictionary<T, U> dictionary)
        {
            _iteratorHelper = new ConcurrentDictionaryConstIteratorHelper<T, U>(dictionary);
        }

        public KeyValuePair<T, U> Current => _iteratorHelper.Current;

        public int Index => _iteratorHelper.Index;

        public bool IsEndIterator => _iteratorHelper.IsEndIterator;

        public bool Previous() => _iteratorHelper.Previous();

        public bool Next() => _iteratorHelper.Next();

        public IEnumerator<KeyValuePair<T, U>> GetEnumerator() => _iteratorHelper.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
