namespace RangeIt.Iterators.Adapters.Const
{
    using Interfaces.Adapters;
    using System.Collections;
    using System.Collections.Generic;

    internal sealed class ListConstIteratorAdapter<T> : BaseListIteratorAdapter<T>, IConstIteratorAdapter<T>
    {
        internal ListConstIteratorAdapter(List<T> list, bool isEnd = false) : base(list, isEnd) { }

        public T Current => _current;

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
