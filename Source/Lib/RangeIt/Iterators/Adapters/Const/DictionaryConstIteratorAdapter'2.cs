namespace RangeIt.Iterators.Adapters.Const
{
    using Base;
    using Interfaces.Adapters;
    using System.Collections.Generic;

    internal sealed class DictionaryConstIteratorAdapter<T, U> : BaseDictionaryIteratorAdapter<T, U>, IConstIteratorAdapter<T, U>
    {
        internal DictionaryConstIteratorAdapter(Dictionary<T, U> dictionary, bool isEnd = false) : base(dictionary, isEnd) { }

        public KeyValuePair<T, U> Current => _current;

        public T Key => Current.Key;

        public U Value => Current.Value;
    }
}
