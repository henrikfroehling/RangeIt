namespace RangeIt.Ranges
{
    using Numeric;
    using System;

    public static partial class Range
    {
        /// <summary>
        /// Returns a generic transformation function for multiplying each element
        /// in a range by the given <paramref name="value" />.
        /// </summary>
        /// <typeparam name="T">The type of the elements in the range.</typeparam>
        /// <typeparam name="C">
        /// The type of the calculator implementation for the range's element type <typeparamref name="T" />.
        /// See also <seealso cref="CalculatorBase{T}" />.
        /// </typeparam>
        /// <param name="value">The value, by which each element will be multiplied.</param>
        /// <returns>A transformation function, that multiplies each element in a range.</returns>
        public static Func<T, T> MultiplyBy<T, C>(T value) where C : CalculatorBase<T>, new()
            => (element) =>
            {
                Number<T, C> elementNumber = element;
                Number<T, C> valueNumber = value;
                return elementNumber * valueNumber;
            };

        /// <summary>
        /// Returns a transformation function, that multiplies each element
        /// in an integer range by the given <paramref name="value" />.
        /// </summary>
        /// <param name="value">The value, by which each element will be multiplied.</param>
        /// <returns>A transformation function, that multiplies each element in an integer range.</returns>
        public static Func<int, int> MultiplyBy(int value) => MultiplyBy<int, IntCalculator>(value);

        /// <summary>
        /// Returns a transformation function, that multiplies each element
        /// in a range with floating-point-values by the given <paramref name="value" />.
        /// </summary>
        /// <param name="value">The value, by which each element will be multiplied.</param>
        /// <returns>A transformation function, that multiplies each element in a range with floating-point-values.</returns>
        public static Func<float, float> MultiplyBy(float value) => MultiplyBy<float, FloatCalculator>(value);

        /// <summary>
        /// Returns a transformation function, that multiplies each element
        /// in a range with floating(double)-point-values by the given <paramref name="value" />.
        /// </summary>
        /// <param name="value">The value, by which each element will be multiplied.</param>
        /// <returns>A transformation function, that multiplies each element in a range with floating(double)-point-values.</returns>
        public static Func<double, double> MultiplyBy(double value) => MultiplyBy<double, DoubleCalculator>(value);

        /// <summary>Returns a filter function for filtering even elements in an integer range.</summary>
        /// <returns>A filter function for filtering even elements</returns>
        public static Func<int, bool> IsEven()
            => (element) =>
            {
                Number<int, IntCalculator> elementNumber = element;
                var moduleNumber = new Number<int, IntCalculator>(2);
                return elementNumber % moduleNumber == 0;
            };

        /// <summary>Returns a filter function for filtering odd elements in an integer range.</summary>
        /// <returns>A filter function for filtering odd elements</returns>
        public static Func<int, bool> IsOdd()
            => (element) =>
            {
                Number<int, IntCalculator> elementNumber = element;
                var moduleNumber = new Number<int, IntCalculator>(2);
                return elementNumber % moduleNumber != 0;
            };
    }
}
