namespace RangeIt.Iterators
{
    using Interfaces;
    using System;
    using System.Collections;

    public sealed class Iterator : IIterator
    {
        private IIterator _iteratorHelper;

        private Iterator() { }

        public Iterator(ArrayList arrayList)
        {

        }

        public Iterator(Queue queue)
        {

        }

        public Iterator(Stack stack)
        {

        }

        public Iterator(SortedList sortedList)
        {

        }

        public int Index
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

            set
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
