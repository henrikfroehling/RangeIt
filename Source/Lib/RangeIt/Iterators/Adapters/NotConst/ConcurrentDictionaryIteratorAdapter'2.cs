namespace RangeIt.Iterators.Adapters.NotConst
{
    using Base;
    using Interfaces.Adapters;
    using System.Collections.Concurrent;
    using System.Collections.Generic;

    internal sealed class ConcurrentDictionaryIteratorAdapter<T, U> : BaseConcurrentDictionaryIteratorAdapter<T, U>, IIteratorAdapter<T, U>
    {
        internal ConcurrentDictionaryIteratorAdapter(ConcurrentDictionary<T, U> dictionary, bool isEnd = false) : base(dictionary, isEnd) { }

        public KeyValuePair<T, U> Current
        {
            get { return _current; }

            set
            {
                if (_isEnd)
                    return;

                if (_index >= 0 && _index < _count)
                {
                    var val = default(U);
                    if (_dictionary.TryRemove(_current.Key, out val))
                    {
                        var newKeyValue = value;
                        _dictionary[newKeyValue.Key] = newKeyValue.Value;
                        _current = newKeyValue;
                    }
                }
            }
        }

        public T Key => Current.Key;

        public U Value => Current.Value;
    }
}
