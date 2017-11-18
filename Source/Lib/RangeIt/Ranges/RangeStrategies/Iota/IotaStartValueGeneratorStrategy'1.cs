namespace RangeIt.Ranges.RangeStrategies.Iota
{
    using System;
    using System.Collections.Generic;

    internal class IotaStartValueGeneratorStrategy<T> : IotaGeneratorStrategy<T>
    {
        internal T StartValue { get; set; }

        internal IotaStartValueGeneratorStrategy(T startValue, uint count, Func<T, T> generator) : base(count, generator)
            => StartValue = startValue;

        public override bool Equals(IRangeStrategy<T> other)
        {
            bool baseEquals = base.Equals(other);

            if (other is IotaStartValueGeneratorStrategy<T>)
                return (other as IotaStartValueGeneratorStrategy<T>)?.StartValue.Equals(StartValue) == true;

            return false;
        }

        public override IEnumerator<T> GetEnumerator()
        {
            uint count = Count;
            Func<T, T> generator = Generator;

            T tmp = StartValue;
            yield return tmp;

            for (int i = 1; i < count; ++i)
            {
                tmp = generator(tmp);
                yield return tmp;
            }
        }
    }
}
