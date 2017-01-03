namespace RangeIt.Iterators.Detail.NotConst
{
    using Interfaces;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    internal struct CollectionIterator<T> : IIterator<T>
    {
        private Collection<T> _collection;
        private T _current;
        private int _index;
        private bool _isEnd;

        internal CollectionIterator(Collection<T> collection, bool isEnd = false)
        {
            if (collection == null)
                throw new ArgumentNullException(nameof(collection));

            _collection = collection;
            _current = default(T);
            _isEnd = isEnd;
            _index = -1;
        }

        public T Current
        {
            get { return _current; }

            set
            {
                if (_isEnd)
                    return;

                if (_index >= 0 && _index < _collection.Count)
                {
                    _current = value;
                    _collection[_index] = _current;
                }
            }
        }

        public int Index => _index;

        public bool IsEndIterator => _isEnd;

        public bool IsValid
        {
            get
            {
                if (IsEndIterator)
                    return false;

                if (_collection != null)
                    return Index >= 0 && Index < _collection.Count;

                return false;
            }
        }

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
