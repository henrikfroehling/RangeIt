namespace RangeIt.Iterators
{
    using Interfaces;
    using System;
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

        public int Index
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public T Current
        {
            get
            {
                throw new NotImplementedException();
            }

            set
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
