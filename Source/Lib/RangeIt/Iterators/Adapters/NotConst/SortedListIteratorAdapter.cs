namespace RangeIt.Iterators.Adapters.NotConst
{
    using Base;
    using Interfaces.Adapters;
    using System.Collections;

    internal sealed class SortedListIteratorAdapter : BaseSortedListIteratorAdapter, IIteratorAdapter
    {
        internal SortedListIteratorAdapter(SortedList sortedList, bool isEnd = false) : base(sortedList, isEnd) { }

        public object Current
        {
            get { return _current; }

            set
            {
                if (_isEnd || _sortedList.IsReadOnly)
                    return;

                if (_index >= 0 && _index < _count)
                {
                    _current = value;
                    _sortedList.SetByIndex(_index, _current);
                }
            }
        }
    }
}
