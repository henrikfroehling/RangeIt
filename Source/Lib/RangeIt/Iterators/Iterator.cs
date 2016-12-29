﻿namespace RangeIt.Iterators
{
    using Helpers;
    using Interfaces;
    using System.Collections;

    public sealed class Iterator : IIterator
    {
        private IIterator _iteratorHelper;

        private Iterator() { }

        public Iterator(ArrayList arrayList)
        {
            _iteratorHelper = new ArrayListIteratorHelper(arrayList);
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

        public object Current
        {
            get { return _iteratorHelper.Current; }
            set { _iteratorHelper.Current = value; }
        }

        public int Index => _iteratorHelper.Index;

        public bool IsEndIterator => _iteratorHelper.IsEndIterator;

        public bool Previous() => _iteratorHelper.Previous();

        public bool Next() => _iteratorHelper.Next();

        public IEnumerator GetEnumerator() => _iteratorHelper.GetEnumerator();
    }
}
