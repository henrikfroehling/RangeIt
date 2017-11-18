namespace RangeIt.Ranges.Numeric
{
    /// <summary>Base class for calculation methods for a specific type <typeparamref name="T" />.</summary>
    /// <typeparam name="T">The type for which this calculator should be implemented.</typeparam>
    public abstract class CalculatorBase<T>
    {
        public abstract T Add(T a, T b);

        public abstract T Subtract(T a, T b);

        public abstract T Multiply(T a, T b);

        public abstract T Divide(T a, T b);

        public abstract T Modulo(T a, T b);

        public abstract bool AreEqual(T a, T b);
    }
}
