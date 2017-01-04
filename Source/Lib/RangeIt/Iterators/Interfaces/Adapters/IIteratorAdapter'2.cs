namespace RangeIt.Iterators.Interfaces.Adapters
{
    using System.Collections.Generic;

    internal interface IIteratorAdapter<T, U> : IIterator<T, U>, IIterable, IEnumerable<KeyValuePair<T, U>>
    {

    }
}
