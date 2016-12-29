namespace RangeIt.Iterators
{
    using Helpers.NotConst;
    using Interfaces;
    using System.Collections;

    public sealed class ConstIterator : IConstIterator
    {
        private IConstIterator _iteratorHelper;

        private ConstIterator() { }

        public ConstIterator(ArrayList arrayList)
        {
            _iteratorHelper = new ArrayListConstIteratorHelper(arrayList);
        }

        public ConstIterator(Queue queue)
        {
            _iteratorHelper = new QueueConstIteratorHelper(queue);
        }

        public ConstIterator(Stack stack)
        {
            _iteratorHelper = new StackConstIteratorHelper(stack);
        }

        public ConstIterator(SortedList sortedList)
        {

        }

        public object Current => _iteratorHelper.Current;

        public int Index => _iteratorHelper.Index;

        public bool IsEndIterator => _iteratorHelper.IsEndIterator;

        public bool Previous() => _iteratorHelper.Previous();

        public bool Next() => _iteratorHelper.Next();

        public IEnumerator GetEnumerator() => _iteratorHelper.GetEnumerator();
    }
}
