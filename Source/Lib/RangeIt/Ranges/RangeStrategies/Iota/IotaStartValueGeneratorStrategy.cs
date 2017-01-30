namespace RangeIt.Ranges.RangeStrategies.Iota
{
    using System;
    using System.Collections.Generic;

    internal class IotaStartValueGeneratorStrategy<T> : IotaGeneratorStrategy<T>
    {
        internal T StartValue { get; set; }

        internal IotaStartValueGeneratorStrategy(T startValue, uint count, Func<T, T> generator)
            : base(count, generator)
        {
            StartValue = startValue;
        }

        public override bool Equals(IRangeStrategy<T> other)
        {
            var baseEquals = base.Equals(other);

            if (other is IotaStartValueGeneratorStrategy<T>)
                return (other as IotaStartValueGeneratorStrategy<T>).StartValue.Equals(StartValue);

            return false;
        }

        public override IEnumerator<T> GetEnumerator()
        {
            var count = Count;
            var generator = Generator;

            var tmp = StartValue;
            yield return tmp;

            for (int i = 1; i < count; ++i)
            {
                tmp = generator(tmp);
                yield return tmp;
            }
        }
    }
}
