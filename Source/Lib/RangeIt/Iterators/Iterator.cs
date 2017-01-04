namespace RangeIt.Iterators
{
    using Interfaces;
    using System;
    using System.Collections;

    public struct Iterator : IIterator, IIterable, IEnumerable
    {
        public Iterator(ArrayList arrayList)
        {

        }

        internal Iterator(ArrayList arrayList, bool isEnd)
        {

        }

        public Iterator(SortedList sortedList)
        {

        }

        internal Iterator(SortedList sortedList, bool isEnd)
        {

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

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
