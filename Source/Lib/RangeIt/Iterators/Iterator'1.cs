namespace RangeIt.Iterators
{
    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public struct Iterator<T>
    {
        public Iterator(T[] items)
        {

        }

        internal Iterator(T[] items, bool isEnd)
        {

        }

        public Iterator(List<T> list)
        {

        }

        internal Iterator(List<T> list, bool isEnd)
        {

        }

        public Iterator(Collection<T> collection)
        {

        }

        internal Iterator(Collection<T> collection, bool isEnd)
        {

        }
    }
}
