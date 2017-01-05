namespace RangeIt.Iterators.Adapters.Const
{
    using Base;
    using Interfaces.Adapters;
    using System.Collections.Concurrent;
    using System.Collections.Generic;

    internal sealed class ConcurrentDictionaryConstIteratorAdapter<T, U> : BaseConcurrentDictionaryIteratorAdapter<T, U>, IConstIteratorAdapter<T, U>
    {
        internal ConcurrentDictionaryConstIteratorAdapter(ConcurrentDictionary<T, U> dictionary, bool isEnd = false) : base(dictionary, isEnd) { }

        public KeyValuePair<T, U> Current => _current;

        public T Key => Current.Key;

        public U Value => Current.Value;
    }
}
