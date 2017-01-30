namespace RangeIt.Ranges.RangeStrategies.Iota
{
    using System.Collections;
    using System.Collections.Generic;

    internal class IotaIntsFromToStrategy : IRangeStrategy<int>
    {
        internal int From { get; set; }

        internal int To { get; set; }

        internal int Step { get; set; }

        internal IotaIntsFromToStrategy(int from, int to, int step)
        {
            From = from;
            To = to;
            Step = step;
        }

        public bool Equals(IRangeStrategy<int> other)
        {
            if (other == null)
                return false;

            if (other is IotaIntsFromToStrategy)
            {
                var strategy = other as IotaIntsFromToStrategy;

                return strategy != null && strategy.From == From
                        && strategy.To == To && strategy.Step == Step;
            }

            return false;
        }

        public IEnumerator<int> GetEnumerator()
        {
            var from = From;
            var to = To;
            var step = Step;

            if (step < 0)
                step *= -1;
            else if (step == 0)
                step = 1;

            while (from < to)
            {
                yield return from;
                from += step;
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
