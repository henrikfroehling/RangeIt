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

        internal Iterator(ArrayList arrayList, bool isEnd)
        {
            _iteratorHelper = new ArrayListIterator(arrayList, isEnd);
        }

        public Iterator(Queue queue)
        {
            _iteratorHelper = new QueueIterator(queue);
        }

        internal Iterator(Queue queue, bool isEnd)
        {
            _iteratorHelper = new QueueIterator(queue, isEnd);
        }

        public Iterator(Stack stack)
        {
            _iteratorHelper = new StackIterator(stack);
        }

        internal Iterator(Stack stack, bool isEnd)
        {
            _iteratorHelper = new StackIterator(stack, isEnd);
        }

        public Iterator(SortedList sortedList)
        {
            _iteratorHelper = new SortedListIterator(sortedList);
        }

        internal Iterator(SortedList sortedList, bool isEnd)
        {
            _iteratorHelper = new SortedListIterator(sortedList, isEnd);
        }

        public object Current
        {
            get { return _iteratorHelper.Current; }
            set { _iteratorHelper.Current = value; }
        }

        public int Index => _iteratorHelper.Index;

        public bool IsEndIterator => _iteratorHelper.IsEndIterator;

        public bool IsValid => _iteratorHelper.IsValid;

        public bool Previous() => _iteratorHelper.Previous();

        public bool Next() => _iteratorHelper.Next();

        public IEnumerator GetEnumerator() => _iteratorHelper.GetEnumerator();

        public override string ToString() => Current?.ToString();

        public static implicit operator bool(Iterator it) => it.IsValid;
    }
}
