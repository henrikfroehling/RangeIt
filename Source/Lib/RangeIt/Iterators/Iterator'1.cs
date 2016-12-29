namespace RangeIt.Iterators
{
    using Helpers;
    using Interfaces;
    using System.Collections;
    using System.Collections.Concurrent;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public sealed class Iterator<T> : IIterator<T>
    {
        private IIterator<T> _iteratorHelper;

        private Iterator() { }

        public Iterator(T[] items)
        {
            _iteratorHelper = new ArrayIteratorHelper<T>(items);
        }

        public Iterator(List<T> list)
        {
            _iteratorHelper = new ListIteratorHelper<T>(list);
        }

        public Iterator(Collection<T> collection)
        {
            _iteratorHelper = new CollectionIteratorHelper<T>(collection);
        }

        public Iterator(ConcurrentQueue<T> queue)
        {
            _iteratorHelper = new ConcurrentQueueIteratorHelper<T>(queue);
        }

        public Iterator(ConcurrentStack<T> stack)
        {
            _iteratorHelper = new ConcurrentStackIteratorHelper<T>(stack);
        }

        public Iterator(ConcurrentBag<T> bag)
        {
            _iteratorHelper = new ConcurrentBagIteratorHelper<T>(bag);
        }

        public T Current
        {
            get { return _iteratorHelper.Current; }
            set { _iteratorHelper.Current = value; }
        }

        public int Index => _iteratorHelper.Index;

        public bool IsEndIterator => _iteratorHelper.IsEndIterator;

        public bool Previous() => _iteratorHelper.Previous();

        public bool Next() => _iteratorHelper.Next();

        public IEnumerator<T> GetEnumerator() => _iteratorHelper.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
