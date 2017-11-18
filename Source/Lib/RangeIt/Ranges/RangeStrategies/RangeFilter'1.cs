namespace RangeIt.Ranges.RangeStrategies
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    internal class RangeFilter<T> : IRangeStrategy<T>
    {
        private Range<T> _range;
        private readonly Func<T, bool> _function;

        internal RangeFilter(Range<T> range, Func<T, bool> function)
        {
            _range = range;
            _function = function ?? throw new ArgumentNullException(nameof(function));
        }

        public bool Equals(IRangeStrategy<T> other)
        {
            if (other == null)
                return false;

            if (other is RangeFilter<T>)
            {
                var transform = other as RangeFilter<T>;
                return transform?._range.Equals(_range) == true && transform._function == _function;
            }

            return false;
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (T val in _range)
            {
                if (_function(val))
                    yield return val;
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
