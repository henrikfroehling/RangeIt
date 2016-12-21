using System;

namespace Ranges
{
    public static class View
    {
        public static int[] Ints(uint count) => Ints(1, count);

        public static int[] Ints(int startValue, uint count)
        {
            var range = new int[count];

            for (int i = 0; i < count; ++i)
                range[i] = startValue++;

            return range;
        }

        public static int[] Iota(int from, int to)
        {
            if (to < from)
                throw new ArgumentOutOfRangeException(nameof(to));

            if (from == to)
                return new int[0];

            var count = to - from;
            var range = new int[count];

            var i = 0;
            while (from < to)
            {
                range[i] = from++;
                i++;
            }

            return range;
        }
    }
}
