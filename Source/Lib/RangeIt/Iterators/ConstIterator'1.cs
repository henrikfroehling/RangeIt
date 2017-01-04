namespace RangeIt.Iterators
{
    using Interfaces;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public struct ConstIterator<T> : IConstIterator<T>, IIterable, IEnumerable<T>
    {
        public ConstIterator(T[] items)
        {

        }

        internal ConstIterator(T[] items, bool isEnd)
        {

        }

        public ConstIterator(List<T> list)
        {

        }

        internal ConstIterator(List<T> list, bool isEnd)
        {

        }

        public ConstIterator(Collection<T> collection)
        {

        }

        internal ConstIterator(Collection<T> collection, bool isEnd)
        {

        }

        public ConstIterator(ReadOnlyCollection<T> collection)
        {

        }

        internal ConstIterator(ReadOnlyCollection<T> collection, bool isEnd)
        {

        }

        public T Current
        {
            get
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
