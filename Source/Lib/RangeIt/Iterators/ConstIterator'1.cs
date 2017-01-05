namespace RangeIt.Iterators
{
    using Adapters.Const;
    using Interfaces;
    using Interfaces.Adapters;
    using System.Collections;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public struct ConstIterator<T> : IConstIterator<T>, IIterable, IEnumerable<T>
    {
        private IConstIteratorAdapter<T> _iteratorAdapter;

        public ConstIterator(T[] items)
        {
            _iteratorAdapter = new ArrayConstIteratorAdapter<T>(items);
        }

        internal ConstIterator(T[] items, bool isEnd)
        {
            _iteratorAdapter = new ArrayConstIteratorAdapter<T>(items, isEnd);
        }

        public ConstIterator(List<T> list)
        {
            _iteratorAdapter = new ListConstIteratorAdapter<T>(list);
        }

        internal ConstIterator(List<T> list, bool isEnd)
        {
            _iteratorAdapter = new ListConstIteratorAdapter<T>(list, isEnd);
        }

        public ConstIterator(Collection<T> collection)
        {
            _iteratorAdapter = new CollectionConstIteratorAdapter<T>(collection);
        }

        internal ConstIterator(Collection<T> collection, bool isEnd)
        {
            _iteratorAdapter = new CollectionConstIteratorAdapter<T>(collection, isEnd);
        }

        public ConstIterator(ReadOnlyCollection<T> collection)
        {
            _iteratorAdapter = new ReadOnlyCollectionConstIteratorAdapter<T>(collection);
        }

        internal ConstIterator(ReadOnlyCollection<T> collection, bool isEnd)
        {
            _iteratorAdapter = new ReadOnlyCollectionConstIteratorAdapter<T>(collection, isEnd);
        }

        public T Current => _iteratorAdapter.Current;

        public int Index => _iteratorAdapter.Index;

        public bool IsEndIterator => _iteratorAdapter.IsEndIterator;

        public bool IsValid => _iteratorAdapter.IsValid;

        public bool Previous() => _iteratorAdapter.Previous();

        public bool Next() => _iteratorAdapter.Next();

        public IEnumerator<T> GetEnumerator() => _iteratorAdapter.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        public override string ToString() => Current?.ToString();

        public static ConstIterator<T> operator --(ConstIterator<T> it)
        {
            it.Previous();
            return it;
        }

        public static ConstIterator<T> operator ++(ConstIterator<T> it)
        {
            it.Next();
            return it;
        }

        public static implicit operator bool(ConstIterator<T> it) => it.IsValid;

        public static explicit operator T(ConstIterator<T> it) => it.Current;
    }
}
