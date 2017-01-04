namespace RangeIt.Iterators
{
    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public struct ConstIterator<T>
    {
        public ConstIterator(T[] items)
        {

        }

        internal ConstIterator(T[] items, bool isEnd)
        {

        }

        public ConstIterator(List<T> list)
        {

        }

        internal ConstIterator(List<T> list, bool isEnd)
        {

        }

        public ConstIterator(Collection<T> collection)
        {

        }

        internal ConstIterator(Collection<T> collection, bool isEnd)
        {

        }

        public ConstIterator(ReadOnlyCollection<T> collection)
        {

        }

        internal ConstIterator(ReadOnlyCollection<T> collection, bool isEnd)
        {

        }
    }
}
