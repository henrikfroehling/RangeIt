namespace RangeIt.Iterators.Adapters.Const
{
    using Base;
    using Interfaces.Adapters;
    using System.Collections.ObjectModel;

    internal sealed class CollectionConstIteratorAdapter<T> : BaseCollectionIteratorAdapter<T>, IConstIteratorAdapter<T>
    {
        internal CollectionConstIteratorAdapter(Collection<T> collection, bool isEnd = false) : base(collection, isEnd) { }

        public T Current => _current;
    }
}
