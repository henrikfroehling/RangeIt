namespace RangeIt.Ranges.RangeStrategies.Iota
{
    using System;
    using System.Collections.Generic;

    internal class IotaStartValueCancelableGeneratorStrategy<T> : IotaCancelableGeneratorStrategy<T>
    {
        internal T StartValue { get; set; }

        internal IotaStartValueCancelableGeneratorStrategy(T startValue, Func<T, T> generator, Func<T, bool> cancellationPredicate) : base(generator, cancellationPredicate)
            => StartValue = startValue;

        public override bool Equals(IRangeStrategy<T> other)
        {
            bool baseEquals = base.Equals(other);

            if (other is IotaStartValueCancelableGeneratorStrategy<T>)
                return (other as IotaStartValueCancelableGeneratorStrategy<T>)?.StartValue.Equals(StartValue) == true;

            return false;
        }

        public override IEnumerator<T> GetEnumerator()
        {
            Func<T, T> generator = Generator;
            Func<T, bool> cancellationPredicate = CancellationPredicate;

            T tmp = StartValue;
            yield return tmp;

            while (!cancellationPredicate(tmp))
            {
                tmp = generator(tmp);
                yield return tmp;
            }
        }
    }
}
