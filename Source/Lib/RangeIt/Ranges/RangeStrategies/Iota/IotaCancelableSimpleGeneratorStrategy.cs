namespace RangeIt.Ranges.RangeStrategies.Iota
{
    using System;
    using System.Collections.Generic;

    internal class IotaCancelableSimpleGeneratorStrategy<T> : AIotaCancelableGeneratorStrategy<T>
    {
        internal Func<T> Generator { get; set; }

        internal IotaCancelableSimpleGeneratorStrategy(Func<T> generator, Func<T, bool> cancellationPredicate) : base(cancellationPredicate)
        {
            if (generator == null)
                throw new ArgumentNullException(nameof(generator));

            Generator = generator;
        }

        public override bool Equals(IRangeStrategy<T> other)
        {
            var baseEquals = base.Equals(other);

            if (other is IotaCancelableSimpleGeneratorStrategy<T>)
                return (other as IotaCancelableSimpleGeneratorStrategy<T>).Generator == Generator;

            return false;
        }

        public override IEnumerator<T> GetEnumerator()
        {
            var generator = Generator;
            var cancellationPredicate = CancellationPredicate;

            while (true)
            {
                var tmp = generator();
                yield return tmp;

                if (cancellationPredicate(tmp))
                    yield break;
            }
        }
    }
}
