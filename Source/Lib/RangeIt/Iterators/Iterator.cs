namespace RangeIt.Iterators
{
    using Detail.NotConst;
    using Interfaces;
    using System.Collections;

    public struct Iterator : IIterator
    {
        private IIterator _iteratorHelper;

        public Iterator(ArrayList arrayList)
        {
            _iteratorHelper = new ArrayListIterator(arrayList);
        }

        public Iterator(Queue queue)
        {
            _iteratorHelper = new QueueIterator(queue);
        }

        public Iterator(Stack stack)
        {
            _iteratorHelper = new StackIterator(stack);
        }

        public Iterator(SortedList sortedList)
        {
            _iteratorHelper = new SortedListIterator(sortedList);
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

        public override string ToString() => Current?.ToString();
    }
}
