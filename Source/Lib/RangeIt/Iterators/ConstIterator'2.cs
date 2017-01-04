namespace RangeIt.Iterators
{
    using System.Collections.Concurrent;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public struct ConstIterator<T, U>
    {
        public ConstIterator(KeyValuePair<T, U>[] items)
        {

        }

        internal ConstIterator(KeyValuePair<T, U>[] items, bool isEnd)
        {

        }

        public ConstIterator(Dictionary<T, U> dictionary)
        {

        }

        internal ConstIterator(Dictionary<T, U> dictionary, bool isEnd)
        {

        }

        public ConstIterator(ReadOnlyDictionary<T, U> dictionary)
        {

        }

        internal ConstIterator(ReadOnlyDictionary<T, U> dictionary, bool isEnd)
        {

        }

        public ConstIterator(ConcurrentDictionary<T, U> dictionary)
        {

        }

        internal ConstIterator(ConcurrentDictionary<T, U> dictionary, bool isEnd)
        {

        }
    }
}
