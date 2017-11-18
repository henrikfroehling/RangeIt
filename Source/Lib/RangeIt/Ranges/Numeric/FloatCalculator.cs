namespace RangeIt.Ranges.Numeric
{
    internal sealed class FloatCalculator : CalculatorBase<float>
    {
        public override float Add(float a, float b) => a + b;

        public override float Subtract(float a, float b) => a - b;

        public override float Multiply(float a, float b) => a * b;

        public override float Divide(float a, float b) => a / b;

        public override float Modulo(float a, float b) => a % b;

        public override bool AreEqual(float a, float b) => a.Equals(b);
    }
}
