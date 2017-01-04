namespace RangeIt.Iterators
{
    using Interfaces;
    using System;
    using System.Collections;

    public struct ConstIterator : IConstIterator, IIterable, IEnumerable
    {
        public ConstIterator(ArrayList arrayList)
        {

        }

        internal ConstIterator(ArrayList arrayList, bool isEnd)
        {

        }

        public ConstIterator(SortedList sortedList)
        {

        }

        internal ConstIterator(SortedList sortedList, bool isEnd)
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
