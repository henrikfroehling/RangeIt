﻿namespace RangeIt.Iterators.Helpers
{
    using Interfaces;
    using System;
    using System.Collections;
    using System.Collections.Generic;

    internal sealed class DictionaryIteratorHelper<T, U> : IIterator<T, U>
    {
        private DictionaryIteratorHelper() { }

        public DictionaryIteratorHelper(Dictionary<T, U> dictionary)
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
