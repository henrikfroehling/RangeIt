namespace RangeIt.Iterators.Interfaces.Adapters
{
    using System.Collections.Generic;

    internal interface IConstIteratorAdapter<T> : IConstIterator<T>, IIterable, IEnumerable<T>
    {
    }
}
