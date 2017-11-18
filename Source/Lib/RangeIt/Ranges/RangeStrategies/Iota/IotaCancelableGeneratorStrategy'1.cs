namespace RangeIt.Ranges.RangeStrategies.Iota
{
    using System;
    using System.Collections.Generic;

    internal class IotaCancelableGeneratorStrategy<T> : AIotaCancelableGeneratorStrategy<T>
    {
        internal Func<T, T> Generator { get; set; }

        internal IotaCancelableGeneratorStrategy(Func<T, T> generator, Func<T, bool> cancellationPredicate) : base(cancellationPredicate)
            => Generator = generator ?? throw new ArgumentNullException(nameof(generator));

        public override bool Equals(IRangeStrategy<T> other)
        {
            bool baseEquals = base.Equals(other);

            if (other is IotaCancelableGeneratorStrategy<T>)
                return (other as IotaCancelableGeneratorStrategy<T>)?.Generator == Generator;

            return false;
        }

        public override IEnumerator<T> GetEnumerator()
        {
            T tmp = default;
            Func<T, T> generator = Generator;
            Func<T, bool> cancellationPredicate = CancellationPredicate;

            while (!cancellationPredicate(tmp))
            {
                tmp = generator(tmp);
                yield return tmp;
            }
        }
    }
}
