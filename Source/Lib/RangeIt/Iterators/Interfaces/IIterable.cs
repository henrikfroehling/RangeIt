namespace RangeIt.Iterators.Interfaces
{
    public interface IIterable
    {
        int Index { get; }

        bool Previous();

        bool Next();
    }
}
