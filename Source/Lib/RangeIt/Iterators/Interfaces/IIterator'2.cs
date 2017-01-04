namespace RangeIt.Iterators.Interfaces
{
    using System.Collections.Generic;

    public interface IIterator<T, U>
    {
        KeyValuePair<T, U> Current { get; set; }

        T Key { get; }

        U Value { get; }
    }
}
