namespace RangeIt.Iterators
{
    using Interfaces;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public struct Iterator<T> : IIterator<T>, IIterable, IEnumerable<T>
    {
        public Iterator(T[] items)
        {

        }

        internal Iterator(T[] items, bool isEnd)
        {

        }

        public Iterator(List<T> list)
        {

        }

        internal Iterator(List<T> list, bool isEnd)
        {

        }

        public Iterator(Collection<T> collection)
        {

        }

        internal Iterator(Collection<T> collection, bool isEnd)
        {

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

        public int Index
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public bool IsEndIterator
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public bool IsValid
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
