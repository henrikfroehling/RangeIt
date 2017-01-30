namespace RangeIt.Ranges.RangeStrategies.Iota
{
    using System.Collections;
    using System.Collections.Generic;

    internal abstract class AIotaGeneratorStrategy<T> : IRangeStrategy<T>
    {
        internal uint Count { get; set; }

        internal AIotaGeneratorStrategy(uint count)
        {
            Count = count;
        }

        public virtual bool Equals(IRangeStrategy<T> other)
        {
            if (other == null)
                return false;

            if (other is AIotaGeneratorStrategy<T>)
                return (other as AIotaGeneratorStrategy<T>).Count == Count;

            return false;
        }

        public abstract IEnumerator<T> GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
