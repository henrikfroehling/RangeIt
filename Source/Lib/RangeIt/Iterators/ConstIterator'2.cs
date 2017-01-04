namespace RangeIt.Iterators
{
    using Interfaces;
    using System;
    using System.Collections;
    using System.Collections.Concurrent;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public struct ConstIterator<T, U> : IConstIterator<T, U>, IIterable, IEnumerable<KeyValuePair<T, U>>
    {
        public ConstIterator(KeyValuePair<T, U>[] items)
        {

        }

        internal ConstIterator(KeyValuePair<T, U>[] items, bool isEnd)
        {

        }

        public ConstIterator(Dictionary<T, U> dictionary)
        {

        }

        internal ConstIterator(Dictionary<T, U> dictionary, bool isEnd)
        {

        }

        public ConstIterator(ReadOnlyDictionary<T, U> dictionary)
        {

        }

        internal ConstIterator(ReadOnlyDictionary<T, U> dictionary, bool isEnd)
        {

        }

        public ConstIterator(ConcurrentDictionary<T, U> dictionary)
        {

        }

        internal ConstIterator(ConcurrentDictionary<T, U> dictionary, bool isEnd)
        {

        }

        public KeyValuePair<T, U> Current
        {
            get
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
