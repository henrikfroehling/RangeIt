namespace RangeIt.Ranges.RangeStrategies.Iota
{
    using System;
    using System.Collections.Generic;

    internal class IotaStartValueSimpleGeneratorStrategy<T> : IotaSimpleGeneratorStrategy<T>
    {
        internal T StartValue { get; set; }

        internal IotaStartValueSimpleGeneratorStrategy(T startValue, uint count, Func<T> generator) : base(count, generator)
            => StartValue = startValue;

        public override bool Equals(IRangeStrategy<T> other)
        {
            bool baseEquals = base.Equals(other);

            if (other is IotaStartValueSimpleGeneratorStrategy<T>)
                return (other as IotaStartValueSimpleGeneratorStrategy<T>)?.StartValue.Equals(StartValue) == true;

            return false;
        }

        public override IEnumerator<T> GetEnumerator()
        {
            T startValue = StartValue;
            uint count = Count;
            Func<T> generator = Generator;

            T tmp = startValue;
            yield return tmp;

            for (int i = 1; i < count; ++i)
                yield return generator();
        }
    }
}
