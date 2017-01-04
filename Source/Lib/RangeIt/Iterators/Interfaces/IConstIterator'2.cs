namespace RangeIt.Iterators.Interfaces
{
    using System.Collections.Generic;

    public interface IConstIterator<T, U> : IIterable, IEnumerable<KeyValuePair<T, U>>
    {
        KeyValuePair<T, U> Current { get; }

        T Key { get; }
    }
}
