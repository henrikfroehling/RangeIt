namespace RangeIt.Iterators.Adapters.Base
{
    using Interfaces;
    using System;
    using System.Collections;

    internal abstract class BaseSortedListIteratorAdapter : IIterable, IEnumerable
    {
        protected SortedList _sortedList;
        protected object _current;
        protected int _index;
        protected bool _isEnd;

        internal BaseSortedListIteratorAdapter(SortedList sortedList, bool isEnd = false)
        {
            if (sortedList == null)
                throw new ArgumentNullException(nameof(sortedList));

            _sortedList = sortedList;
            _current = default(object);
            _isEnd = isEnd;
            _index = -1;
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
