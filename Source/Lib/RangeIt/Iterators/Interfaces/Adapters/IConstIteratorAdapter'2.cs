namespace RangeIt.Iterators.Interfaces.Adapters
{
    using System.Collections.Generic;

    internal interface IConstIteratorAdapter<T, U> : IConstIterator<T, U>, IIterable, IEnumerable<KeyValuePair<T, U>>
    {

    }
}
