namespace RangeIt.Iterators.Helpers
{
    using Interfaces;
    using System;
    using System.Collections;
    using System.Collections.Concurrent;
    using System.Collections.Generic;

    internal sealed class ConcurrentStackIteratorHelper<T> : IIterator<T>
    {
        private ConcurrentStackIteratorHelper() { }

        public ConcurrentStackIteratorHelper(ConcurrentStack<T> stack)
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

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public bool Next()
        {
            throw new NotImplementedException();
        }

        public bool Previous()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
