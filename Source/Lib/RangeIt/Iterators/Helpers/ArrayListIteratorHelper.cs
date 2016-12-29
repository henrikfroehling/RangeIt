namespace RangeIt.Iterators.Helpers
{
    using Interfaces;
    using System;
    using System.Collections;

    internal sealed class ArrayListIteratorHelper : IIterator
    {
        private ArrayListIteratorHelper() { }

        public ArrayListIteratorHelper(ArrayList arrayList)
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
