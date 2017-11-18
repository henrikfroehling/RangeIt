namespace RangeIt.Ranges.RangeStrategies.Iota
{
    using System;
    using System.Collections.Generic;

    internal class IotaSimpleGeneratorStrategy<T> : AIotaGeneratorStrategy<T>
    {
        internal Func<T> Generator { get; set; }

        internal IotaSimpleGeneratorStrategy(uint count, Func<T> generator) : base(count)
            => Generator = generator ?? throw new ArgumentNullException(nameof(generator));

        public override bool Equals(IRangeStrategy<T> other)
        {
            bool baseEquals = base.Equals(other);

            if (other is IotaSimpleGeneratorStrategy<T>)
                return (other as IotaSimpleGeneratorStrategy<T>)?.Generator == Generator;

            return false;
        }

        public override IEnumerator<T> GetEnumerator()
        {
            uint count = Count;
            Func<T> generator = Generator;

            for (int i = 0; i < count; ++i)
                yield return generator();
        }
    }
}
