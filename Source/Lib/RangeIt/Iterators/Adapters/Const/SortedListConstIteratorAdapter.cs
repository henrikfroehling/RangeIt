namespace RangeIt.Iterators.Adapters.Const
{
    using Base;
    using Interfaces.Adapters;
    using System.Collections;

    internal sealed class SortedListConstIteratorAdapter : BaseSortedListIteratorAdapter, IConstIteratorAdapter
    {
        internal SortedListConstIteratorAdapter(SortedList sortedList, bool isEnd = false) : base(sortedList, isEnd) { }

        public object Current => _current;
    }
}
