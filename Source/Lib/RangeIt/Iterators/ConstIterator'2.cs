namespace RangeIt.Iterators
{
    using Interfaces;
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public sealed class ConstIterator<T, U> : IConstIterator<T, U>
    {
        public KeyValuePair<T, U> Current
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

        public IEnumerator<KeyValuePair<T, U>> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
