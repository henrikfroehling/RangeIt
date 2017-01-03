namespace RangeIt.Iterators.Detail.NotConst
{
    using Interfaces;
    using System;
    using System.Collections;

    internal struct ArrayListIterator : IIterator
    {
        private ArrayList _arrayList;
        private object _current;
        private int _index;
        private bool _isEnd;

        internal ArrayListIterator(ArrayList arrayList, bool isEnd = false)
        {
            if (arrayList == null)
                throw new ArgumentNullException(nameof(arrayList));

            _arrayList = arrayList;
            _current = default(object);
            _isEnd = isEnd;
            _index = -1;
        }

        public object Current
        {
            get { return _current; }

            set
            {
                if (_isEnd || _arrayList.IsReadOnly)
                    return;

                if (_index >= 0 && _index < _arrayList.Count)
                {
                    _current = value;
                    _arrayList[_index] = _current;
                }
            }
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
