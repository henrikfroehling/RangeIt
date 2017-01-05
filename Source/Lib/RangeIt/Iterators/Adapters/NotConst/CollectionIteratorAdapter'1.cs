namespace RangeIt.Iterators.Adapters.NotConst
{
    using Base;
    using Interfaces.Adapters;
    using System.Collections.ObjectModel;

    internal sealed class CollectionIteratorAdapter<T> : BaseCollectionIteratorAdapter<T>, IIteratorAdapter<T>
    {
        internal CollectionIteratorAdapter(Collection<T> collection, bool isEnd = false) : base(collection, isEnd) { }

        public T Current
        {
            get { return _current; }

            set
            {
                if (_isEnd)
                    return;

                if (_index >= 0 && _index < _collection.Count)
                {
                    _current = value;
                    _collection[_index] = _current;
                }
            }
        }
    }
}
