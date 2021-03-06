﻿namespace RangeIt.Ranges.RangeStrategies.Ints
{
    using System.Collections.Generic;

    internal class IntsWithStepStrategy : IntsStrategy
    {
        internal int Step { get; set; }

        internal IntsWithStepStrategy(uint count, int step) : base(count)
            => Step = step;

        internal IntsWithStepStrategy(int startValue, uint count, int step) : base(startValue, count)
            => Step = step;

        public override bool Equals(IRangeStrategy<int> other)
        {
            bool baseEquals = base.Equals(other);

            if (other is IntsWithStepStrategy)
                return (other as IntsWithStepStrategy).Step == Step;

            return false;
        }

        public override IEnumerator<int> GetEnumerator()
        {
            uint count = Count;
            int step = Step;
            int startValue = StartValue;

            for (int i = 0; i < count; ++i)
            {
                yield return startValue;
                startValue += step;
            }
        }
    }
}
