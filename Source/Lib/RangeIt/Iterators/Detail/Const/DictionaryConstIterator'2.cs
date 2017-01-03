namespace RangeIt.Iterators.Detail.Const
{
    using Interfaces;
    using System;
    using System.Collections;
    using System.Collections.Generic;

    internal struct DictionaryConstIterator<T, U> : IConstIterator<T, U>
    {
        public DictionaryConstIterator(Dictionary<T, U> dictionary)
        {

        }

        public KeyValuePair<T, U> Current
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
