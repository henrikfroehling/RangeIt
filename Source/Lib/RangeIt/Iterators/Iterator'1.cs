namespace RangeIt.Iterators
{
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

        }

        public Iterator(List<T> list)
        {

        }

        public Iterator(Collection<T> collection)
        {

        }

        public Iterator(ConcurrentQueue<T> queue)
        {

        }

        public Iterator(ConcurrentStack<T> stack)
        {

        }

        public Iterator(ConcurrentBag<T> bag)
        {

        }

        public int Index => _iteratorHelper.Index;

        public bool IsEndIterator => _iteratorHelper.IsEndIterator;

        public T Current
        {
            get { return _iteratorHelper.Current; }
            set { _iteratorHelper.Current = value; }
        }

        public bool Previous() => _iteratorHelper.Previous();

        public bool Next() => _iteratorHelper.Next();

        public IEnumerator<T> GetEnumerator() => _iteratorHelper.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
