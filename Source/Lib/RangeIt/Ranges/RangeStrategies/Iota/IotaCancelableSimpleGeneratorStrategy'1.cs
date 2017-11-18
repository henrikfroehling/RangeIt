namespace RangeIt.Ranges.RangeStrategies.Iota
{
    using System;
    using System.Collections.Generic;

    internal class IotaCancelableSimpleGeneratorStrategy<T> : AIotaCancelableGeneratorStrategy<T>
    {
        internal Func<T> Generator { get; set; }

        internal IotaCancelableSimpleGeneratorStrategy(Func<T> generator, Func<T, bool> cancellationPredicate) : base(cancellationPredicate)
            => Generator = generator ?? throw new ArgumentNullException(nameof(generator));

        public override bool Equals(IRangeStrategy<T> other)
        {
            bool baseEquals = base.Equals(other);

            if (other is IotaCancelableSimpleGeneratorStrategy<T>)
                return (other as IotaCancelableSimpleGeneratorStrategy<T>)?.Generator == Generator;

            return false;
        }

        public override IEnumerator<T> GetEnumerator()
        {
            Func<T> generator = Generator;
            Func<T, bool> cancellationPredicate = CancellationPredicate;

            while (true)
            {
                T tmp = generator();
                yield return tmp;

                if (cancellationPredicate(tmp))
                    yield break;
            }
        }
    }
}
