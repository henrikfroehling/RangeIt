namespace RangeIt.Iterators
{
    using Interfaces;
    using System;
    using System.Collections;
    using System.Collections.Concurrent;
    using System.Collections.Generic;

    public struct Iterator<T, U> : IIterator<T, U>, IIterable, IEnumerable<KeyValuePair<T, U>>
    {
        public Iterator(KeyValuePair<T, U>[] items)
        {

        }

        internal Iterator(KeyValuePair<T, U>[] items, bool isEnd)
        {

        }

        public Iterator(Dictionary<T, U> dictionary)
        {

        }

        internal Iterator(Dictionary<T, U> dictionary, bool isEnd)
        {

        }

        public Iterator(ConcurrentDictionary<T, U> dictionary)
        {

        }

        internal Iterator(ConcurrentDictionary<T, U> dictionary, bool isEnd)
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

        public T Key
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public U Value
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
