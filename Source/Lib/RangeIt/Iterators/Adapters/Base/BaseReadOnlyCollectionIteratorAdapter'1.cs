namespace RangeIt.Iterators.Adapters.Base
{
    using Interfaces;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    internal abstract class BaseReadOnlyCollectionIteratorAdapter<T> : IIterable, IEnumerable<T>
    {
        protected ReadOnlyCollection<T> _collection;
        protected T _current;
        protected int _index;
        protected bool _isEnd;

        internal BaseReadOnlyCollectionIteratorAdapter(ReadOnlyCollection<T> collection, bool isEnd = false)
        {
            if (collection == null)
                throw new ArgumentNullException(nameof(collection));

            _collection = collection;
            _current = default(T);
            _isEnd = isEnd;
            _index = -1;
        }

        public int Index => _index;

        public bool IsEndIterator => _isEnd;

        public bool IsValid => !IsEndIterator && Index >= 0 && Index < _collection.Count;

        public bool Previous()
        {
            var count = _collection.Count;

            if (count == 0)
                return false;

            if (_index == 0)
            {
                _isEnd = false;
                _index = -1;
                _current = default(T);
                return false;
            }

            if (_isEnd)
                _index = count;

            if (_index >= 1)
            {
                _isEnd = false;
                --_index;
                _current = _collection[_index];
                return true;
            }

            return false;
        }

        public bool Next()
        {
            var count = _collection.Count;

            if (_isEnd || count == 0)
                return false;

            if (_index == count - 1)
            {
                _index = count;
                _isEnd = true;
                _current = default(T);
                return false;
            }

            if (_index < count - 1)
            {
                _index++;
                _current = _collection[_index];
                return true;
            }

            _isEnd = true;
            return false;
        }

        public IEnumerator<T> GetEnumerator() => _collection.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
