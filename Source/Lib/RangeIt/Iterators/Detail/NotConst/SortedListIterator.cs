namespace RangeIt.Iterators.Detail.NotConst
{
    using Interfaces;
    using System;
    using System.Collections;

    internal struct SortedListIterator : IIterator
    {
        private SortedList _sortedList;
        private object _current;
        private int _index;
        private bool _isEnd;

        internal SortedListIterator(SortedList sortedList, bool isEnd = false)
        {
            if (sortedList == null)
                throw new ArgumentNullException(nameof(sortedList));

            _sortedList = sortedList;
            _current = default(object);
            _isEnd = isEnd;
            _index = -1;
        }

        public object Current
        {
            get { return _current; }

            set
            {
                if (_isEnd || _sortedList.IsReadOnly)
                    return;

                if (_index >= 0 && _index < _sortedList.Count)
                {
                    _current = value;
                    _sortedList.SetByIndex(_index, _current);
                }
            }
        }

        public int Index => _index;

        public bool IsEndIterator => _isEnd;

        public bool IsValid => !IsEndIterator && Index >= 0 && Index < _sortedList.Count;

        public bool Previous()
        {
            var count = _sortedList.Count;

            if (count == 0)
                return false;

            if (_index == 0)
            {
                _isEnd = false;
                _index = -1;
                _current = default(object);
                return false;
            }

            if (_isEnd)
                _index = count;

            if (_index >= 1)
            {
                _isEnd = false;
                --_index;
                _current = _sortedList.GetByIndex(_index);
                return true;
            }

            return false;
        }

        public bool Next()
        {
            var count = _sortedList.Count;

            if (_isEnd || count == 0)
                return false;

            if (_index == count - 1)
            {
                _index = count;
                _isEnd = true;
                _current = default(object);
                return false;
            }

            if (_index < count - 1)
            {
                _index++;
                _current = _sortedList.GetByIndex(_index);
                return true;
            }

            _isEnd = true;
            return false;
        }

        public IEnumerator GetEnumerator() => _sortedList.GetEnumerator();
    }
}
