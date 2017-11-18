namespace RangeIt.Ranges.RangeStrategies
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    internal class RangeTransform<T> : IRangeStrategy<T>
    {
        private Range<T> _range;
        private readonly Func<T, T> _function;

        internal RangeTransform(Range<T> range, Func<T, T> function)
        {
            _range = range;
            _function = function ?? throw new ArgumentNullException(nameof(function));
        }

        public bool Equals(IRangeStrategy<T> other)
        {
            if (other == null)
                return false;

            if (other is RangeTransform<T>)
            {
                var transform = other as RangeTransform<T>;
                return transform?._range.Equals(_range) == true && transform._function == _function;
            }

            return false;
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (T val in _range)
                yield return _function(val);
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
