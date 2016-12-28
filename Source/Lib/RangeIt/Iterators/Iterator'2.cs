namespace RangeIt.Iterators
{
    using Interfaces;
    using System;
    using System.Collections;
    using System.Collections.Concurrent;
    using System.Collections.Generic;

    public sealed class Iterator<T, U> : IIterator<T, U>
    {
        private IIterator<T, U> _iteratorHelper;

        private Iterator() { }

        public Iterator(KeyValuePair<T, U>[] items)
        {

        }

        public Iterator(Dictionary<T, U> dictionary)
        {

        }

        public Iterator(ConcurrentDictionary<T, U> dictionary)
        {

        }

        public KeyValuePair<T, U> Current
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
