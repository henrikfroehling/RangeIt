﻿namespace RangeIt.Iterators.Detail.NotConst
{
    using Interfaces;
    using System;
    using System.Collections;
    using System.Collections.Concurrent;
    using System.Collections.Generic;

    internal struct ConcurrentBagIterator<T> : IIterator<T>
    {
        internal ConcurrentBagIterator(ConcurrentBag<T> bag, bool isEnd = false)
        {

        }

        public T Current
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

        public IEnumerator<T> GetEnumerator()
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