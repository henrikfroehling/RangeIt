namespace RangeIt.Iterators.Adapters.NotConst
{
    using Base;
    using Interfaces.Adapters;
    using System.Linq;

    internal sealed class ArrayIteratorAdapter<T> : BaseArrayIteratorAdapter<T>, IIteratorAdapter<T>
    {
        internal ArrayIteratorAdapter(T[] items, bool isEnd = false) : base(items, isEnd) { }

        public T Current
        {
            get { return _current; }

            set
            {
                if (_isEnd)
                    return;

                if (_index >= 0 && _index < _items.Count())
                {
                    _current = value;
                    _items[_index] = _current;
                }
            }
        }
    }
}
