namespace RangeIt.Iterators
{
    using Detail.NotConst;
    using Interfaces;
    using System.Collections;
    using System.Collections.Concurrent;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public struct Iterator<T> : IIterator<T>
    {
        private IIterator<T> _iteratorHelper;

        public Iterator(T[] items)
        {
            _iteratorHelper = new ArrayIterator<T>(items);
        }

        public Iterator(List<T> list)
        {
            _iteratorHelper = new ListIterator<T>(list);
        }

        public Iterator(Collection<T> collection)
        {
            _iteratorHelper = new CollectionIterator<T>(collection);
        }

        public Iterator(ConcurrentQueue<T> queue)
        {
            _iteratorHelper = new ConcurrentQueueIterator<T>(queue);
        }

        public Iterator(ConcurrentStack<T> stack)
        {
            _iteratorHelper = new ConcurrentStackIterator<T>(stack);
        }

        public Iterator(ConcurrentBag<T> bag)
        {
            _iteratorHelper = new ConcurrentBagIterator<T>(bag);
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

        public override string ToString() => Current?.ToString();
    }
}
