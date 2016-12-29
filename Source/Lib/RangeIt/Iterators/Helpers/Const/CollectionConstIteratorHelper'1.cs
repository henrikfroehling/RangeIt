namespace RangeIt.Iterators.Helpers.Const
{
    using Interfaces;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    internal sealed class CollectionConstIteratorHelper<T> : IConstIterator<T>
    {
        private CollectionConstIteratorHelper() { }

        public CollectionConstIteratorHelper(Collection<T> collection)
        {

        }

        public T Current
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
