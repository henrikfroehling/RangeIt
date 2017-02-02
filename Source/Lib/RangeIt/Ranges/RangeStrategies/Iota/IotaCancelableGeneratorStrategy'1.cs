namespace RangeIt.Ranges.RangeStrategies.Iota
{
    using System;
    using System.Collections.Generic;

    internal class IotaCancelableGeneratorStrategy<T> : AIotaCancelableGeneratorStrategy<T>
    {
        internal Func<T, T> Generator { get; set; }

        internal IotaCancelableGeneratorStrategy(Func<T, T> generator, Func<T, bool> cancellationPredicate) : base(cancellationPredicate)
        {
            if (generator == null)
                throw new ArgumentNullException(nameof(generator));

            Generator = generator;
        }

        public override bool Equals(IRangeStrategy<T> other)
        {
            var baseEquals = base.Equals(other);

            if (other is IotaCancelableGeneratorStrategy<T>)
                return (other as IotaCancelableGeneratorStrategy<T>).Generator == Generator;

            return false;
        }

        public override IEnumerator<T> GetEnumerator()
        {
            var tmp = default(T);
            var generator = Generator;
            var cancellationPredicate = CancellationPredicate;

            while (!cancellationPredicate(tmp))
            {
                tmp = generator(tmp);
                yield return tmp;
            }
        }
    }
}
