namespace RangeIt.Iterators
{
    using System.Collections.Concurrent;
    using System.Collections.Generic;

    public struct Iterator<T, U>
    {
        public Iterator(KeyValuePair<T, U>[] items)
        {

        }

        internal Iterator(KeyValuePair<T, U>[] items, bool isEnd)
        {

        }

        public Iterator(Dictionary<T, U> dictionary)
        {

        }

        internal Iterator(Dictionary<T, U> dictionary, bool isEnd)
        {

        }

        public Iterator(ConcurrentDictionary<T, U> dictionary)
        {

        }

        internal Iterator(ConcurrentDictionary<T, U> dictionary, bool isEnd)
        {

        }
    }
}
