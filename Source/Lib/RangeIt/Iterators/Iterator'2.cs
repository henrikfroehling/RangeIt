namespace RangeIt.Iterators
{
    using Interfaces;
    using System.Collections;
    using System.Collections.Concurrent;
    using System.Collections.Generic;

    public sealed class Iterator<T, U> : IIterator<T, U>
    {
        private IIterator<T, U> _iteratorHelper;

        private Iterator() { }

        public Iterator(KeyValuePair<T, U>[] items)
        {

        }

        public Iterator(Dictionary<T, U> dictionary)
        {

        }

        public Iterator(ConcurrentDictionary<T, U> dictionary)
        {

        }

        public KeyValuePair<T, U> Current
        {
            get { return _iteratorHelper.Current; }
            set { _iteratorHelper.Current = value; }
        }

        public int Index => _iteratorHelper.Index;

        public bool IsEndIterator => _iteratorHelper.IsEndIterator;

        public bool Previous() => _iteratorHelper.Previous();

        public bool Next() => _iteratorHelper.Next();

        public IEnumerator<KeyValuePair<T, U>> GetEnumerator() => _iteratorHelper.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
