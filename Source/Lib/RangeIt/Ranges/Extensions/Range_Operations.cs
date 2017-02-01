namespace RangeIt.Ranges
{
    using System;

    public static partial class Range
    {
        /// <summary>
        /// Applies a given filter <paramref name="function" /> to each element in the given
        /// <paramref name="range" /> and returns a new range with elements, that are sufficient
        /// to the condition of the given filter <paramref name="function" />.
        /// </summary>
        /// <typeparam name="T">The type of the elements in the given <paramref name="range" />.</typeparam>
        /// <param name="range">The range containing the elements, on which the given filter <paramref name="function" /> will be applied.</param>
        /// <param name="function">The filter function, which will be applied to each element in the given <paramref name="range" />.</param>
        /// <returns>A <see cref="Range{T}" />, containing the filtered elements.</returns>
        public static Range<T> Filter<T>(this Range<T> range, Func<T, bool> function)
            => range |= function;

        /// <summary>
        /// Applies a given <paramref name="function" /> to each element in the given
        /// <paramref name="range" />.
        /// </summary>
        /// <typeparam name="T">The type of the elements in the given <paramref name="range" />.</typeparam>
        /// <param name="range">The range containing the elements, on which the given <paramref name="function" /> will be applied.</param>
        /// <param name="function">The function, which will be applied to each element in the given <paramref name="range" />.</param>
        /// <returns>A <see cref="Range{T}" />, containing the transformed elements.</returns>
        public static Range<T> Transform<T>(this Range<T> range, Func<T, T> function)
            => range |= function;
    }
}
