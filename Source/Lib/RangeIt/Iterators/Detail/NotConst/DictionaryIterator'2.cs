namespace RangeIt.Iterators.Detail.NotConst
{
    using Interfaces;
    using System;
    using System.Collections;
    using System.Collections.Generic;

    internal struct DictionaryIterator<T, U> : IIterator<T, U>
    {
        internal DictionaryIterator(Dictionary<T, U> dictionary, bool isEnd = false)
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

            set
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

        public bool IsValid
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public IEnumerator<KeyValuePair<T, U>> GetEnumerator()
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
