namespace RangeIt.Iterators
{
    using Detail.NotConst;
    using Interfaces;
    using System.Collections;

    public sealed class Iterator : IIterator
    {
        private IIterator _iteratorHelper;

        private Iterator() { }

        public Iterator(ArrayList arrayList)
        {
            _iteratorHelper = new ArrayListIteratorHelper(arrayList);
        }

        public Iterator(Queue queue)
        {
            _iteratorHelper = new QueueIteratorHelper(queue);
        }

        public Iterator(Stack stack)
        {
            _iteratorHelper = new StackIteratorHelper(stack);
        }

        public Iterator(SortedList sortedList)
        {
            _iteratorHelper = new SortedListIteratorHelper(sortedList);
        }

        public object Current
        {
            get { return _iteratorHelper.Current; }
            set { _iteratorHelper.Current = value; }
        }

        public int Index => _iteratorHelper.Index;

        public bool IsEndIterator => _iteratorHelper.IsEndIterator;

        public bool Previous() => _iteratorHelper.Previous();

        public bool Next() => _iteratorHelper.Next();

        public IEnumerator GetEnumerator() => _iteratorHelper.GetEnumerator();
    }
}
