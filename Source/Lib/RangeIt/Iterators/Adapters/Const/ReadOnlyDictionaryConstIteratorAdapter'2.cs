namespace RangeIt.Iterators.Adapters.Const
{
    using Base;
    using Interfaces.Adapters;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    internal sealed class ReadOnlyDictionaryConstIteratorAdapter<T, U> : BaseReadOnlyDictionaryIteratorAdapter<T, U>, IConstIteratorAdapter<T, U>
    {
        internal ReadOnlyDictionaryConstIteratorAdapter(ReadOnlyDictionary<T, U> dictionary, bool isEnd = false) : base(dictionary, isEnd) { }

        public KeyValuePair<T, U> Current => _current;

        public T Key => Current.Key;

        public U Value => Current.Value;
    }
}
