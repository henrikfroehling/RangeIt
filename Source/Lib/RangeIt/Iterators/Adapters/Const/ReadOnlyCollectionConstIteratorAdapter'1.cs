namespace RangeIt.Iterators.Adapters.Const
{
    using Base;
    using Interfaces.Adapters;
    using System.Collections.ObjectModel;

    internal sealed class ReadOnlyCollectionConstIteratorAdapter<T> : BaseReadOnlyCollectionIteratorAdapter<T>, IConstIteratorAdapter<T>
    {
        internal ReadOnlyCollectionConstIteratorAdapter(ReadOnlyCollection<T> collection, bool isEnd = false) : base(collection, isEnd) { }

        public T Current => _current;
    }
}
