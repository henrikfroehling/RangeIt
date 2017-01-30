namespace RangeIt.Ranges
{
    using RangeStrategies.Ints;

    public static partial class Range
    {
        /// <summary>
        /// Generates a range containing a given number of sequential and distinct integers,
        /// starting with value 1.
        /// </summary>
        /// <param name="count">The number of integers, which will be generated.</param>
        /// <returns>
        /// A <see cref="Range{T}" /> of ints, containing the generated integers.
        /// If <paramref name="count"/> is 0, the returned <see cref="Range{T}" /> will be empty.
        /// </returns>
        public static Range<int> Ints(uint count) => Ints(1, count);

        /// <summary>
        /// Generates a range containing a given number of sequential and distinct integers,
        /// starting with value 1.
        /// </summary>
        /// <param name="count">The number of integers, which will be generated.</param>
        /// <param name="step">The difference between two sequential values in the generated range.</param>
        /// <returns>
        /// A <see cref="Range{T}" /> of ints, containing the generated integers.
        /// If <paramref name="count"/> is 0, the returned <see cref="Range{T}" /> will be empty.
        /// </returns>
        public static Range<int> IntsWithStep(uint count, int step) => Ints(1, count, step);

        /// <summary>
        /// Generates a range containing a given number of sequential and distinct integers,
        /// starting with a given <paramref name="startValue" />.
        /// </summary>
        /// <param name="startValue">The start value, at which the generated range starts.</param>
        /// <param name="count">The number of integers, which will be generated.</param>
        /// <returns>
        /// A <see cref="Range{T}" /> of ints, containing the generated integers.
        /// If <paramref name="count"/> is 0, the returned <see cref="Range{T}" /> will be empty.
        /// </returns>
        public static Range<int> Ints(int startValue, uint count)
            => new Range<int>(new IntsStrategy(startValue, count));

        /// <summary>
        /// Generates a range containing a given number of sequential and distinct integers,
        /// starting with a given <paramref name="startValue" />.
        /// </summary>
        /// <param name="startValue">The start value, at which the generated range starts.</param>
        /// <param name="count">The number of integers, which will be generated.</param>
        /// <param name="step">The difference between two sequential values in the generated range.</param>
        /// <returns>
        /// A <see cref="Range{T}" /> of ints, containing the generated integers.
        /// If <paramref name="count"/> is 0, the returned <see cref="Range{T}" /> will be empty.
        /// </returns>
        public static Range<int> Ints(int startValue, uint count, int step)
            => new Range<int>(new IntsWithStepStrategy(startValue, count, step));
    }
}
