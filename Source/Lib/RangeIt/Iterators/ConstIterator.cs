namespace RangeIt.Iterators
{
    using Detail.Const;
    using Interfaces;
    using System.Collections;

    public struct ConstIterator : IConstIterator
    {
        private IConstIterator _iteratorHelper;

        public ConstIterator(ArrayList arrayList)
        {
            _iteratorHelper = new ArrayListConstIterator(arrayList);
        }

        public ConstIterator(Queue queue)
        {
            _iteratorHelper = new QueueConstIterator(queue);
        }

        public ConstIterator(Stack stack)
        {
            _iteratorHelper = new StackConstIterator(stack);
        }

        public ConstIterator(SortedList sortedList)
        {
            _iteratorHelper = new SortedListConstIterator(sortedList);
        }

        public object Current => _iteratorHelper.Current;

        public int Index => _iteratorHelper.Index;

        public bool IsEndIterator => _iteratorHelper.IsEndIterator;

        public bool Previous() => _iteratorHelper.Previous();

        public bool Next() => _iteratorHelper.Next();

        public IEnumerator GetEnumerator() => _iteratorHelper.GetEnumerator();
    }
}
