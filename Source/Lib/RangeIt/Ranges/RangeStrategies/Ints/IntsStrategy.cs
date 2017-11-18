namespace RangeIt.Ranges.RangeStrategies.Ints
{
    using System.Collections;
    using System.Collections.Generic;

    internal class IntsStrategy : IRangeStrategy<int>
    {
        internal int StartValue { get; set; }
        internal uint Count { get; set; }

        internal IntsStrategy(uint count) : this(1, count) { }

        internal IntsStrategy(int startValue, uint count)
        {
            StartValue = startValue;
            Count = count;
        }

        public virtual bool Equals(IRangeStrategy<int> other)
        {
            if (other == null)
                return false;

            if (other is IntsStrategy)
                return (other as IntsStrategy).Count == Count;

            return false;
        }

        public virtual IEnumerator<int> GetEnumerator()
        {
            int startValue = StartValue;

            for (int i = 0; i < Count; ++i)
                yield return startValue++;
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
