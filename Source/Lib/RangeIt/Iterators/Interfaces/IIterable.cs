namespace RangeIt.Iterators.Interfaces
{
    public interface IIterable
    {
        int Index { get; }

        bool IsEndIterator { get; }

        bool IsValid { get; }

        bool Previous();

        bool Next();
    }
}
