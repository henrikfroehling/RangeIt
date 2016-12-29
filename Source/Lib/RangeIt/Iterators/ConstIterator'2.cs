namespace RangeIt.Iterators
{
    using Interfaces;
    using System;
    using System.Collections;
    using System.Collections.Concurrent;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public sealed class ConstIterator<T, U> : IConstIterator<T, U>
    {
        private IConstIterator<T, U> _iteratorHelper;

        private ConstIterator() { }

        public ConstIterator(KeyValuePair<T, U>[] items)
        {

        }

        public ConstIterator(Dictionary<T, U> dictionary)
        {

        }

        public ConstIterator(ReadOnlyDictionary<T, U> dictionary)
        {

        }

        public ConstIterator(ConcurrentDictionary<T, U> dictionary)
        {

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
