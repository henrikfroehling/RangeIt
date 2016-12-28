namespace RangeIt.Iterators.Interfaces
{
    using System.Collections;

    public interface IIterator : IIterable, IEnumerable
    {
        object Current { get; set; }
    }
}
