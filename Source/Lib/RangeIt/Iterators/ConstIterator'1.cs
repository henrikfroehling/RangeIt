namespace RangeIt.Iterators
{
    using Interfaces;
    using System;
    using System.Collections;
    using System.Collections.Concurrent;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public sealed class ConstIterator<T> : IConstIterator<T>
    {
        private ConstIterator() { }

        public ConstIterator(T[] items)
        {

        }

        public ConstIterator(List<T> list)
        {

        }

        public ConstIterator(Collection<T> collection)
        {

        }

        public ConstIterator(ReadOnlyCollection<T> collection)
        {

        }

        public ConstIterator(ConcurrentQueue<T> collection)
        {

        }

        public ConstIterator(ConcurrentStack<T> collection)
        {

        }

        public ConstIterator(ConcurrentBag<T> collection)
        {

        }

        public T Current
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public bool Previous()
        {
            throw new NotImplementedException();
        }

        public bool Next()
        {
            throw new NotImplementedException();
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
