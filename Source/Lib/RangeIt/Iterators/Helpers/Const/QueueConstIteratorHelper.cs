namespace RangeIt.Iterators.Helpers.Const
{
    using Interfaces;
    using System;
    using System.Collections;

    internal sealed class QueueConstIteratorHelper : IConstIterator
    {
        private QueueConstIteratorHelper() { }

        public QueueConstIteratorHelper(Queue queue)
        {

        }

        public object Current
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

        public IEnumerator GetEnumerator()
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
    }
}
