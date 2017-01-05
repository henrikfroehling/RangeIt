namespace RangeIt.Iterators.Adapters.NotConst
{
    using Base;
    using Interfaces.Adapters;
    using System.Collections.Generic;
    using System.Linq;

    internal sealed class ArrayIteratorAdapter<T, U> : BaseArrayIteratorAdapter<T, U>, IIteratorAdapter<T, U>
    {
        internal ArrayIteratorAdapter(KeyValuePair<T, U>[] items, bool isEnd = false) : base(items, isEnd) { }

        public KeyValuePair<T, U> Current
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

        public T Key => Current.Key;

        public U Value => Current.Value;
    }
}
