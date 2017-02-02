namespace RangeIt.Ranges.Numeric
{
    public abstract class CalculatorBase<T>
    {
        public abstract T Add(T a, T b);

        public abstract T Subtract(T a, T b);

        public abstract T Multiply(T a, T b);

        public abstract T Divide(T a, T b);

        public abstract T Module(T a, T b);

        public abstract bool AreEqual(T a, T b);
    }
}
