namespace RangeIt.Iterators
{
    using Interfaces;
    using System.Collections;

    public sealed class ConstIterator : IConstIterator
    {
        private IConstIterator _iteratorHelper;

        private ConstIterator() { }

        public ConstIterator(ArrayList arrayList)
        {

        }

        public ConstIterator(Queue queue)
        {

        }

        public ConstIterator(Stack stack)
        {

        }

        public ConstIterator(SortedList sortedList)
        {

        }

        public int Index => _iteratorHelper.Index;

        public bool IsEndIterator => _iteratorHelper.IsEndIterator;

        public object Current => _iteratorHelper.Current;

        public bool Previous() => _iteratorHelper.Previous();

        public bool Next() => _iteratorHelper.Next();

        public IEnumerator GetEnumerator() => _iteratorHelper.GetEnumerator();
    }
}
