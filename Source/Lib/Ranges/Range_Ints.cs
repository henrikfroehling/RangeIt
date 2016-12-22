namespace Ranges
{
    using System.Collections.Generic;

    public static partial class Range
    {
        public static IEnumerable<int> Ints(uint count) => Ints(1, count);

        public static IEnumerable<int> Ints(int startValue, uint count)
        {
            for (int i = 0; i < count; ++i)
                yield return startValue++;
        }
    }
}
