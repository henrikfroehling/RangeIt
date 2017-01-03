namespace RangeIt.Iterators
{
    using Detail.Const;
    using Interfaces;
    using System.Collections;
    using System.Collections.Concurrent;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public struct ConstIterator<T> : IConstIterator<T>
    {
        private IConstIterator<T> _iteratorHelper;

        public ConstIterator(T[] items)
        {
            _iteratorHelper = new ArrayConstIterator<T>(items);
        }

        public ConstIterator(List<T> list)
        {
            _iteratorHelper = new ListConstIterator<T>(list);
        }

        public ConstIterator(Collection<T> collection)
        {
            _iteratorHelper = new CollectionConstIterator<T>(collection);
        }

        public ConstIterator(ReadOnlyCollection<T> collection)
        {
            _iteratorHelper = new ReadOnlyCollectionConstIterator<T>(collection);
        }

        public ConstIterator(ConcurrentQueue<T> queue)
        {
            _iteratorHelper = new ConcurrentQueueConstIterator<T>(queue);
        }

        public ConstIterator(ConcurrentStack<T> stack)
        {
            _iteratorHelper = new ConcurrentStackConstIterator<T>(stack);
        }

        public ConstIterator(ConcurrentBag<T> bag)
        {
            _iteratorHelper = new ConcurrentBagConstIterator<T>(bag);
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
