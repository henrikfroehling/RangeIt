namespace RangeIt.Iterators.Adapters.Const
{
    using Base;
    using Interfaces.Adapters;

    internal sealed class ArrayConstIteratorAdapter<T> : BaseArrayIteratorAdapter<T>, IConstIteratorAdapter<T>
    {
        internal ArrayConstIteratorAdapter(T[] items, bool isEnd = false) : base(items, isEnd) { }

        public T Current => _current;
    }
}
