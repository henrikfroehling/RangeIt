namespace RangeIt.Ranges.RangeStrategies
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    internal class RangeFilter<T> : IRangeStrategy<T>
    {
        private Range<T> _range;
        private Func<T, bool> _function;

        internal RangeFilter(Range<T> range, Func<T, bool> function)
        {
            if (function == null)
                throw new ArgumentNullException(nameof(function));

            _range = range;
            _function = function;
        }

        public bool Equals(IRangeStrategy<T> other)
        {
            if (other == null)
                return false;

            if (other is RangeFilter<T>)
            {
                var transform = other as RangeFilter<T>;

                return transform != null && transform._range.Equals(_range)
                        && transform._function == _function;
            }

            return false;
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (var val in _range)
            {
                if (_function(val))
                    yield return val;
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
