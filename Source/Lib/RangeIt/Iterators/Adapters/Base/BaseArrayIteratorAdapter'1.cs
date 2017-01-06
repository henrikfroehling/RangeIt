namespace RangeIt.Iterators.Adapters.Base
{
    using Interfaces;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    internal abstract class BaseArrayIteratorAdapter<T> : IIterable, IEnumerable<T>
    {
        protected T[] _items;
        protected T _current;
        protected int _index;
        protected bool _isEnd;
        protected int _count;
        protected int _lastIndex;

        internal BaseArrayIteratorAdapter(T[] items, bool isEnd = false)
        {
            if (items == null)
                throw new ArgumentNullException(nameof(items));

            _items = items;
            _current = default(T);
            _isEnd = isEnd;
            _index = -1;
            _count = _items.Count();
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
                _current = default(T);
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
                _current = default(T);
                return false;
            }

            _isEnd = true;
            return false;
        }

        public IEnumerator<T> GetEnumerator() => _items.Cast<T>().GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
