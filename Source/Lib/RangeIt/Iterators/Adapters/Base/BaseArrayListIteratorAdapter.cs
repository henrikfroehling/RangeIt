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

        internal BaseArrayListIteratorAdapter(ArrayList arrayList, bool isEnd = false)
        {
            if (arrayList == null)
                throw new ArgumentNullException(nameof(arrayList));

            _arrayList = arrayList;
            _current = default(object);
            _isEnd = isEnd;
            _index = -1;
        }

        public int Index => _index;

        public bool IsEndIterator => _isEnd;

        public bool IsValid => !IsEndIterator && Index >= 0 && Index < _arrayList.Count;

        public bool Previous()
        {
            var count = _arrayList.Count;

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
                _current = _arrayList[_index];
                return true;
            }

            return false;
        }

        public bool Next()
        {
            var count = _arrayList.Count;

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
                _current = _arrayList[_index];
                return true;
            }

            _isEnd = true;
            return false;
        }

        public IEnumerator GetEnumerator() => _arrayList.GetEnumerator();
    }
}
