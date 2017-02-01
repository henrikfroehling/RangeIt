namespace RangeIt.Ranges
{
    using RangeStrategies;
    using System;
    using System.Collections;
    using System.Collections.Generic;

    /// <summary>A range collection containing elements of type <typeparamref name="T" />.</summary>
    /// <typeparam name="T">The type of the elements in this range.</typeparam>
    public struct Range<T> : IEnumerable<T>, IEquatable<Range<T>>
    {
        private IRangeStrategy<T> _strategy;

        internal Range(IRangeStrategy<T> strategy)
        {
            if (strategy == null)
                throw new ArgumentNullException(nameof(strategy));

            _strategy = strategy;
        }

        /// <summary>Returns a <see cref="IEnumerator{T}" /> for this range.</summary>
        /// <returns>A <see cref="IEnumerator{T}" />.</returns>
        public IEnumerator<T> GetEnumerator() => _strategy.GetEnumerator();

        /// <summary>Returns a <see cref="IEnumerator" /> for this range.</summary>
        /// <returns>A <see cref="IEnumerator" />.</returns>
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        /// <summary>Indicates whether this range is equal to the given range <paramref name="other" />.</summary>
        /// <param name="other">The range, which will be compared to this range.</param>
        /// <returns>
        /// True, if the given range <paramref name="other" />
        /// is equal to this range, otherwise false.
        /// </returns>
        public bool Equals(Range<T> other) => other._strategy.Equals(_strategy);

        /// <summary>Returns a string representation of this range as comma-separated list.</summary>
        /// <returns>A string representation of this range as comma-separated list.</returns>
        /// <seealso cref="ToString(string)" />
        public override string ToString() => ToString(",");

        /// <summary>
        /// Returns a string representation of this range as a list separated
        /// by a given <paramref name="separator" />.
        /// </summary>
        /// <param name="separator">A separator to be placed between each element in the range string representation.</param>
        /// <returns>A string representation of this range as comma-separated list.</returns>
        /// <seealso cref="ToString()" />
        public string ToString(string separator) => string.Join(separator, _strategy);

        /// <summary>
        /// Applies a given <paramref name="function" /> to each element in the given
        /// <paramref name="range" />.
        /// </summary>
        /// <param name="range">The range containing the elements, on which the given <paramref name="function" /> will be applied.</param>
        /// <param name="function">The function, which will be applied to each element in the given <paramref name="range" />.</param>
        /// <returns>A <see cref="Range{T}" />, containing the transformed elements.</returns>
        public static Range<T> operator |(Range<T> range, Func<T, T> function)
            => new Range<T>(new RangeTransform<T>(range, function));

        /// <summary>
        /// Applies a given filter <paramref name="function" /> to each element in the given
        /// <paramref name="range" /> and returns a new range with elements, that are sufficient
        /// to the condition of the given filter <paramref name="function" />.
        /// </summary>
        /// <param name="range">The range containing the elements, on which the given filter <paramref name="function" /> will be applied.</param>
        /// <param name="function">The filter function, which will be applied to each element in the given <paramref name="range" />.</param>
        /// <returns>A <see cref="Range{T}" />, containing the filtered elements.</returns>
        public static Range<T> operator |(Range<T> range, Func<T, bool> function)
            => new Range<T>(new RangeFilter<T>(range, function));
    }
}
