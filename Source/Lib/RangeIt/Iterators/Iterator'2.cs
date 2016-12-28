namespace RangeIt.Iterators
{
    using Interfaces;
    using System;
    using System.Collections;
    using System.Collections.Concurrent;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public sealed class Iterator<T, U> : IIterator<T, U>
    {
        private Iterator() { }

        public Iterator(KeyValuePair<T, U>[] items)
        {

        }

        public Iterator(Dictionary<T, U> dictionary)
        {

        }

        public Iterator(ReadOnlyDictionary<T, U> dictionary)
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
