namespace RangeIt.Ranges.RangeStrategies
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    internal class RangeTransform<T> : IRangeStrategy<T>
    {
        private Range<T> _range;
        private Func<T, T> _function;

        internal RangeTransform(Range<T> range, Func<T, T> function)
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

            if (other is RangeTransform<T>)
            {
                var transform = other as RangeTransform<T>;

                return transform != null && transform._range.Equals(_range)
                        && transform._function == _function;
            }

            return false;
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (var val in _range)
                yield return _function(val);
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
