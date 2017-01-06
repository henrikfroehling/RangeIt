namespace RangeIt.Iterators.Adapters.NotConst
{
    using Base;
    using Interfaces.Adapters;
    using System.Collections.Generic;

    internal sealed class ListIteratorAdapter<T> : BaseListIteratorAdapter<T>, IIteratorAdapter<T>
    {
        internal ListIteratorAdapter(List<T> list, bool isEnd = false) : base(list, isEnd) { }

        public T Current
        {
            get { return _current; }

            set
            {
                if (_isEnd)
                    return;

                if (_index >= 0 && _index < _count)
                {
                    _current = value;
                    _list[_index] = _current;
                }
            }
        }
    }
}
