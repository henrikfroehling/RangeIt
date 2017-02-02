namespace RangeIt.Ranges.RangeStrategies.Iota
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    internal abstract class AIotaCancelableGeneratorStrategy<T> : IRangeStrategy<T>
    {
        internal Func<T, bool> CancellationPredicate { get; set; }

        internal AIotaCancelableGeneratorStrategy(Func<T, bool> cancellationPredicate)
        {
            if (cancellationPredicate == null)
                throw new ArgumentNullException(nameof(cancellationPredicate));

            CancellationPredicate = cancellationPredicate;
        }

        public virtual bool Equals(IRangeStrategy<T> other)
        {
            if (other == null)
                return false;

            if (other is AIotaCancelableGeneratorStrategy<T>)
                return (other as AIotaCancelableGeneratorStrategy<T>).CancellationPredicate == CancellationPredicate;

            return false;
        }

        public abstract IEnumerator<T> GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
