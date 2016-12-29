namespace RangeIt.Iterators
{
    using Interfaces;
    using System;
    using System.Collections;

    public sealed class ConstIterator : IConstIterator
    {
        private IConstIterator _iteratorHelper;

        private ConstIterator() { }

        public ConstIterator(ArrayList arrayList)
        {

        }

        public ConstIterator(Queue queue)
        {

        }

        public ConstIterator(Stack stack)
        {

        }

        public ConstIterator(SortedList sortedList)
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

        public object Current
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

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
