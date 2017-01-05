namespace RangeIt.Iterators.Adapters.Const
{
    using Base;
    using Interfaces.Adapters;
    using System.Collections.Generic;

    internal sealed class ArrayConstIteratorAdapter<T, U> : BaseArrayIteratorAdapter<T, U>, IConstIteratorAdapter<T, U>
    {
        internal ArrayConstIteratorAdapter(KeyValuePair<T, U>[] items, bool isEnd = false) : base(items, isEnd) { }

        public KeyValuePair<T, U> Current => _current;

        public T Key => Current.Key;

        public U Value => Current.Value;
    }
}
