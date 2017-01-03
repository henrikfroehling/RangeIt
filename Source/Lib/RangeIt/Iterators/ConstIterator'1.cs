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

        internal ConstIterator(T[] items, bool isEnd)
        {
            _iteratorHelper = new ArrayConstIterator<T>(items, isEnd);
        }

        public ConstIterator(List<T> list)
        {
            _iteratorHelper = new ListConstIterator<T>(list);
        }

        internal ConstIterator(List<T> list, bool isEnd)
        {
            _iteratorHelper = new ListConstIterator<T>(list, isEnd);
        }

        public ConstIterator(Collection<T> collection)
        {
            _iteratorHelper = new CollectionConstIterator<T>(collection);
        }

        internal ConstIterator(Collection<T> collection, bool isEnd)
        {
            _iteratorHelper = new CollectionConstIterator<T>(collection, isEnd);
        }

        public ConstIterator(ReadOnlyCollection<T> collection)
        {
            _iteratorHelper = new ReadOnlyCollectionConstIterator<T>(collection);
        }

        internal ConstIterator(ReadOnlyCollection<T> collection, bool isEnd)
        {
            _iteratorHelper = new ReadOnlyCollectionConstIterator<T>(collection, isEnd);
        }

        public ConstIterator(ConcurrentQueue<T> queue)
        {
            _iteratorHelper = new ConcurrentQueueConstIterator<T>(queue);
        }

        internal ConstIterator(ConcurrentQueue<T> queue, bool isEnd)
        {
            _iteratorHelper = new ConcurrentQueueConstIterator<T>(queue, isEnd);
        }

        public ConstIterator(ConcurrentStack<T> stack)
        {
            _iteratorHelper = new ConcurrentStackConstIterator<T>(stack);
        }

        internal ConstIterator(ConcurrentStack<T> stack, bool isEnd)
        {
            _iteratorHelper = new ConcurrentStackConstIterator<T>(stack, isEnd);
        }

        public ConstIterator(ConcurrentBag<T> bag)
        {
            _iteratorHelper = new ConcurrentBagConstIterator<T>(bag);
        }

        internal ConstIterator(ConcurrentBag<T> bag, bool isEnd)
        {
            _iteratorHelper = new ConcurrentBagConstIterator<T>(bag, isEnd);
        }

        public T Current => _iteratorHelper.Current;

        public int Index => _iteratorHelper.Index;

        public bool IsEndIterator => _iteratorHelper.IsEndIterator;

        public bool IsValid => _iteratorHelper.IsValid;

        public bool Previous() => _iteratorHelper.Previous();

        public bool Next() => _iteratorHelper.Next();

        public IEnumerator<T> GetEnumerator() => _iteratorHelper.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        public override string ToString() => Current?.ToString();

        public static implicit operator bool(ConstIterator<T> it) => it.IsValid;
    }
}
