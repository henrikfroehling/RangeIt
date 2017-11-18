namespace RangeIt.Iterators.Adapters.Base
{
    using Interfaces;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    internal abstract class BaseArrayIteratorAdapter<T, U> : IIterable, IEnumerable<KeyValuePair<T, U>>
    {
        protected KeyValuePair<T, U>[] _items;
        protected KeyValuePair<T, U> _current;
        protected int _index;
        protected bool _isEnd;
        protected int _count;
        protected int _lastIndex;

        internal BaseArrayIteratorAdapter(KeyValuePair<T, U>[] items, bool isEnd = false)
        {
            _items = items ?? throw new ArgumentNullException(nameof(items));
            _current = default;
            _isEnd = isEnd;
            _index = -1;
            _count = _items.Length;
            _lastIndex = _count - 1;
        }

        public int Index => _index;

        public bool IsEndIterator => _isEnd;

        public bool IsValid => !IsEndIterator && Index >= 0 && Index < _count;

        public bool Previous()
        {
            if (_count == 0)
                return false;

            if (_isEnd)
                _index = _count;

            if (_index >= 1)
            {
                _isEnd = false;
                --_index;
                _current = _items[_index];
                return true;
            }

            if (_index == 0)
            {
                _isEnd = false;
                _index = -1;
                _current = default;
                return false;
            }

            return false;
        }

        public bool Next()
        {
            if (_isEnd || _count == 0)
                return false;

            if (_index < _lastIndex)
            {
                _index++;
                _current = _items[_index];
                return true;
            }

            if (_index == _lastIndex)
            {
                _index = _count;
                _isEnd = true;
                _current = default;
                return false;
            }

            _isEnd = true;
            return false;
        }

        public IEnumerator<KeyValuePair<T, U>> GetEnumerator() => _items.Cast<KeyValuePair<T, U>>().GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
