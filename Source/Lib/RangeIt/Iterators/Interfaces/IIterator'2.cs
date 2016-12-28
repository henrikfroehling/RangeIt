namespace RangeIt.Iterators.Interfaces
{
    using System.Collections.Generic;

    public interface IIterator<T, U> : IIterable, IEnumerable<KeyValuePair<T, U>>
    {

    }
}
