namespace RangeIt.Ranges.RangeStrategies.Iota
{
    using System;
    using System.Collections.Generic;

    internal class IotaGeneratorStrategy<T> : AIotaGeneratorStrategy<T>
    {
        internal Func<T, T> Generator { get; set; }

        internal IotaGeneratorStrategy(uint count, Func<T, T> generator) : base(count)
            => Generator = generator ?? throw new ArgumentNullException(nameof(generator));

        public override bool Equals(IRangeStrategy<T> other)
        {
            bool baseEquals = base.Equals(other);

            if (other is IotaGeneratorStrategy<T>)
                return (other as IotaGeneratorStrategy<T>)?.Generator == Generator;

            return false;
        }

        public override IEnumerator<T> GetEnumerator()
            => throw new NotImplementedException();
    }
}
