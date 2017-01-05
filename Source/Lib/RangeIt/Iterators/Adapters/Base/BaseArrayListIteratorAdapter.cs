namespace RangeIt.Iterators.Adapters.Base
{
    using Interfaces;
    using System;
    using System.Collections;

    internal abstract class BaseArrayListIteratorAdapter : IIterable, IEnumerable
    {
        protected ArrayList _arrayList;
        protected object _current;
        protected int _index;
        protected bool _isEnd;
        protected int _count;
        protected int _lastIndex;

        internal BaseArrayListIteratorAdapter(ArrayList arrayList, bool isEnd = false)
        {
            if (arrayList == null)
                throw new ArgumentNullException(nameof(arrayList));

            _arrayList = arrayList;
            _current = default(object);
            _isEnd = isEnd;
            _index = -1;
            _count = _arrayList.Count;
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
                _current = _arrayList[_index];
                return true;
            }

            if (_index == 0)
            {
                _isEnd = false;
                _index = -1;
                _current = default(object);
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
                _current = _arrayList[_index];
                return true;
            }

            if (_index == _lastIndex)
            {
                _index = _count;
                _isEnd = true;
                _current = default(object);
                return false;
            }

            _isEnd = true;
            return false;
        }

        public IEnumerator GetEnumerator() => _arrayList.GetEnumerator();
    }
}
