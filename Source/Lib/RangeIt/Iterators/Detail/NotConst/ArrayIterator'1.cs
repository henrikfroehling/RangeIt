namespace RangeIt.Iterators.Detail.NotConst
{
    using Interfaces;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    internal struct ArrayIterator<T> : IIterator<T>
    {
        private T[] _items;
        private T _current;
        private int _index;
        private bool _isEnd;

        internal ArrayIterator(T[] items, bool isEnd = false)
        {
            if (items == null)
                throw new ArgumentNullException(nameof(items));

            _items = items;
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

                if (_index >= 0 && _index < _items.Count())
                {
                    _current = value;
                    _items[_index] = _current;
                }
            }
        }

        public int Index => _index;

        public bool IsEndIterator => _isEnd;

        public bool IsValid => !IsEndIterator && Index >= 0 && Index < _items.Count();

        public bool Previous()
        {
            var count = _items.Count();

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
                _current = _items[_index];
                return true;
            }

            return false;
        }

        public bool Next()
        {
            var count = _items.Count();

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
                _current = _items[_index];
                return true;
            }

            _isEnd = true;
            return false;
        }

        public IEnumerator<T> GetEnumerator() => _items.Cast<T>().GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
