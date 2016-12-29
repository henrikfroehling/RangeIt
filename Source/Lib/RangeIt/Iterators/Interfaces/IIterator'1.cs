namespace RangeIt.Iterators.Interfaces
{
    using System.Collections.Generic;

    public interface IIterator<T> : IIterable, IEnumerable<T>
    {
        T Current { get; set; }
    }
}
