namespace RangeIt.Ranges.Numeric
{
    internal sealed class IntCalculator : CalculatorBase<int>
    {
        public override int Add(int a, int b) => a + b;

        public override int Subtract(int a, int b) => a - b;

        public override int Multiply(int a, int b) => a * b;

        public override int Divide(int a, int b) => a / b;

        public override int Modulo(int a, int b) => a % b;

        public override bool AreEqual(int a, int b) => a == b;
    }
}
