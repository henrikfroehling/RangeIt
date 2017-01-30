namespace RangeIt.Ranges
{
    using RangeStrategies;
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public struct Range<T> : IEnumerable<T>, IEquatable<Range<T>>
    {
        private IRangeStrategy<T> _strategy;

        internal Range(IRangeStrategy<T> strategy)
        {
            if (strategy == null)
                throw new ArgumentNullException(nameof(strategy));

            _strategy = strategy;
        }

        public IEnumerator<T> GetEnumerator() => _strategy.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        public bool Equals(Range<T> other) => other._strategy.Equals(_strategy);

        public override string ToString() => ToString(",");

        public string ToString(string separator) => string.Join(separator, _strategy);
    }
}
