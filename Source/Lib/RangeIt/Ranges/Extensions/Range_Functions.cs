namespace RangeIt.Ranges
{
    using Numeric;
    using System;

    public static partial class Range
    {
        public static Func<T, T> MultiplyBy<T, C>(T value) where C : CalculatorBase<T>, new()
            => (element) =>
            {
                Number<T, C> elementNumber = element;
                Number<T, C> valueNumber = value;
                return elementNumber * valueNumber;
            };

        public static Func<int, int> MultiplyBy(int value) => MultiplyBy<int, IntCalculator>(value);

        public static Func<float, float> MultiplyBy(float value) => MultiplyBy<float, FloatCalculator>(value);

        public static Func<double, double> MultiplyBy(double value) => MultiplyBy<double, DoubleCalculator>(value);

        public static Func<int, bool> IsEven()
            => (element) =>
            {
                Number<int, IntCalculator> elementNumber = element;
                var moduleNumber = new Number<int, IntCalculator>(2);
                return elementNumber % moduleNumber == 0;
            };

        public static Func<int, bool> IsOdd()
            => (element) =>
            {
                Number<int, IntCalculator> elementNumber = element;
                var moduleNumber = new Number<int, IntCalculator>(2);
                return elementNumber % moduleNumber != 0;
            };
    }
}
