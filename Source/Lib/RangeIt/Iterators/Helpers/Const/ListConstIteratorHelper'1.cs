namespace RangeIt.Iterators.Helpers.NotConst
{
    using Interfaces;
    using System;
    using System.Collections;
    using System.Collections.Generic;

    internal sealed class ListConstIteratorHelper<T> : IConstIterator<T>
    {
        private ListConstIteratorHelper() { }

        public ListConstIteratorHelper(List<T> list)
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
