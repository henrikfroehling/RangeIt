namespace RangeIt.Iterators.Adapters.NotConst
{
    using Base;
    using Interfaces.Adapters;
    using System.Collections.Generic;

    internal sealed class DictionaryIteratorAdapter<T, U> : BaseDictionaryIteratorAdapter<T, U>, IIteratorAdapter<T, U>
    {
        internal DictionaryIteratorAdapter(Dictionary<T, U> dictionary, bool isEnd = false) : base(dictionary, isEnd) { }

        public KeyValuePair<T, U> Current
        {
            get { return _current; }

            set
            {
                if (_isEnd)
                    return;

                if (_index >= 0 && _index < _count)
                {
                    var newKeyValue = value;

                    _dictionary.Remove(_current.Key);
                    _dictionary[newKeyValue.Key] = newKeyValue.Value;
                    _current = newKeyValue;
                }
            }
        }

        public T Key => Current.Key;

        public U Value => Current.Value;
    }
}
