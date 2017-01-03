namespace RangeIt.Iterators.Detail.NotConst
{
    using Interfaces;
    using System;
    using System.Collections;
    using System.Collections.Generic;

    internal sealed class ListIterator<T> : IIterator<T>
    {
        private List<T> _list;
        private T _current;
        private int _index;
        private bool _isEnd;

        private ListIterator() { }

        public ListIterator(List<T> list, bool isEnd = false)
        {
            if (list == null)
                throw new ArgumentNullException(nameof(list));

            _list = list;
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

                if (_index >= 0 && _index < _list.Count)
                {
                    _current = value;
                    _list[_index] = _current;
                }
            }
        }

        public int Index => _index;

        public bool IsEndIterator => _isEnd;

        public bool Previous()
        {
            if (_list.Count == 0)
                return false;

            if (_index == 0)
            {
                _isEnd = false;
                _index = -1;
                _current = default(T);
                return false;
            }

            if (_isEnd)
                _index = _list.Count;

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
            if (_isEnd || _list.Count == 0)
                return false;

            if (_index == _list.Count - 1)
            {
                _index = _list.Count;
                _isEnd = true;
                _current = default(T);
                return false;
            }

            if (_index < _list.Count - 1)
            {
                _index++;
                _current = _list[_index];
                return true;
            }

            _isEnd = true;
            return false;
        }

        public IEnumerator<T> GetEnumerator() => _list?.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
