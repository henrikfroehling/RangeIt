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

        public Iterator(T[] items, bool isEnd = false)
        {
            _iteratorHelper = new ArrayIterator<T>(items);
        }

        public Iterator(List<T> list, bool isEnd = false)
        {
            _iteratorHelper = new ListIterator<T>(list, isEnd);
        }

        public Iterator(Collection<T> collection, bool isEnd = false)
        {
            _iteratorHelper = new CollectionIterator<T>(collection);
        }

        public Iterator(ConcurrentQueue<T> queue, bool isEnd = false)
        {
            _iteratorHelper = new ConcurrentQueueIterator<T>(queue);
        }

        public Iterator(ConcurrentStack<T> stack, bool isEnd = false)
        {
            _iteratorHelper = new ConcurrentStackIterator<T>(stack);
        }

        public Iterator(ConcurrentBag<T> bag, bool isEnd = false)
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

        public bool IsValid => _iteratorHelper.IsValid;

        public bool Previous() => _iteratorHelper.Previous();

        public bool Next() => _iteratorHelper.Next();

        public IEnumerator<T> GetEnumerator() => _iteratorHelper.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        public override string ToString() => Current?.ToString();
    }
}
