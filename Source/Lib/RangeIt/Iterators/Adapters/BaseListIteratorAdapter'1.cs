namespace RangeIt.Iterators.Adapters
{
    using Interfaces;
    using System;
    using System.Collections;
    using System.Collections.Generic;

    internal abstract class BaseListIteratorAdapter<T> : IIterable, IEnumerable<T>
    {
        protected List<T> _list;
        protected T _current;
        protected int _index;
        protected bool _isEnd;

        internal BaseListIteratorAdapter(List<T> list, bool isEnd = false)
        {
            if (list == null)
                throw new ArgumentNullException(nameof(list));

            _list = list;
            _current = default(T);
            _isEnd = isEnd;
            _index = -1;
        }

        public int Index => _index;

        public bool IsEndIterator => _isEnd;

        public bool IsValid => !IsEndIterator && Index >= 0 && Index < _list.Count;

        public bool Previous()
        {
            var count = _list.Count;

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
                _current = _list[_index];
                return true;
            }

            return false;
        }

        public bool Next()
        {
            var count = _list.Count;

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
                _current = _list[_index];
                return true;
            }

            _isEnd = true;
            return false;
        }

        public IEnumerator<T> GetEnumerator() => _list.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
