namespace RangeIt.Iterators.Interfaces.Adapters
{
    using System.Collections.Generic;

    internal interface IIteratorAdapter<T> : IIterator<T>, IIterable, IEnumerable<T>
    {
    }
}
