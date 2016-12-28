namespace RangeIt
{
    using System.Collections.Generic;

    public static partial class Functional
    {
        public static IEnumerable<int> ints(uint count) => Range.Ints(count);

        public static IEnumerable<int> ints(int startValue, uint count) => Range.Ints(startValue, count);
    }
}
