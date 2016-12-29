namespace RangeIt.Iterators
{
    using Helpers.Const;
    using Interfaces;
    using System.Collections;
    using System.Collections.Concurrent;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public sealed class ConstIterator<T> : IConstIterator<T>
    {
        private IConstIterator<T> _iteratorHelper;

        private ConstIterator() { }

        public ConstIterator(T[] items)
        {
            _iteratorHelper = new ArrayConstIteratorHelper<T>(items);
        }

        public ConstIterator(List<T> list)
        {
            _iteratorHelper = new ListConstIteratorHelper<T>(list);
        }

        public ConstIterator(Collection<T> collection)
        {
            _iteratorHelper = new CollectionConstIteratorHelper<T>(collection);
        }

        public ConstIterator(ReadOnlyCollection<T> collection)
        {
            _iteratorHelper = new ReadOnlyCollectionConstIteratorHelper<T>(collection);
        }

        public ConstIterator(ConcurrentQueue<T> queue)
        {
            _iteratorHelper = new ConcurrentQueueConstIteratorHelper<T>(queue);
        }

        public ConstIterator(ConcurrentStack<T> stack)
        {
            _iteratorHelper = new ConcurrentStackConstIteratorHelper<T>(stack);
        }

        public ConstIterator(ConcurrentBag<T> bag)
        {

        }

        public T Current => _iteratorHelper.Current;

        public int Index => _iteratorHelper.Index;

        public bool IsEndIterator => _iteratorHelper.IsEndIterator;

        public bool Previous() => _iteratorHelper.Previous();

        public bool Next() => _iteratorHelper.Next();

        public IEnumerator<T> GetEnumerator() => _iteratorHelper.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
