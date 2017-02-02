namespace RangeIt.Ranges.Numeric
{
    using System;

    public struct Number<T, C> : IEquatable<Number<T, C>> where C : CalculatorBase<T>, new()
    {
        private static readonly C _calculator = new C();

        private T _value;

        internal Number(T value)
        {
            _value = value;
        }

        public static implicit operator Number<T, C>(T value) => new Number<T, C>(value);

        public static implicit operator T(Number<T, C> number) => number._value;

        public static Number<T, C> operator +(Number<T, C> lhs, Number<T, C> rhs)
            => _calculator.Add(lhs._value, rhs._value);

        public static Number<T, C> operator -(Number<T, C> lhs, Number<T, C> rhs)
            => _calculator.Subtract(lhs._value, rhs._value);

        public static Number<T, C> operator *(Number<T, C> lhs, Number<T, C> rhs)
            => _calculator.Multiply(lhs._value, rhs._value);

        public static Number<T, C> operator /(Number<T, C> lhs, Number<T, C> rhs)
            => _calculator.Divide(lhs._value, rhs._value);

        public static Number<T, C> operator %(Number<T, C> lhs, Number<T, C> rhs)
            => _calculator.Module(lhs._value, rhs._value);

        public static bool operator ==(Number<T, C> lhs, Number<T, C> rhs)
            => _calculator.AreEqual(lhs._value, rhs._value);

        public static bool operator !=(Number<T, C> lhs, Number<T, C> rhs)
            => !(lhs == rhs);

        public bool Equals(Number<T, C> other) => this == other;

        public override bool Equals(object obj) => Equals((Number<T, C>)obj);

        public override int GetHashCode() => _value.GetHashCode();
    }
}
