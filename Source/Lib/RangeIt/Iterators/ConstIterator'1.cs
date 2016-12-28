namespace RangeIt.Iterators
{
    using Interfaces;
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public sealed class ConstIterator<T> : IConstIterator<T>
    {
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
