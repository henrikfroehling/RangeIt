namespace RangeIt.Iterators.Interfaces
{
    using System.Collections.Generic;

    public interface IConstIterator<T, U>
    {
        KeyValuePair<T, U> Current { get; }

        T Key { get; }

        U Value { get; }
    }
}
