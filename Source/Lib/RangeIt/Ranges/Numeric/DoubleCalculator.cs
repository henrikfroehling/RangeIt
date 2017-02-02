namespace RangeIt.Ranges.Numeric
{
    internal sealed class DoubleCalculator : CalculatorBase<double>
    {
        public override double Add(double a, double b) => a + b;

        public override double Subtract(double a, double b) => a - b;

        public override double Multiply(double a, double b) => a * b;

        public override double Divide(double a, double b) => a / b;

        public override double Modulo(double a, double b) => a % b;

        public override bool AreEqual(double a, double b) => a.Equals(b);
    }
}
