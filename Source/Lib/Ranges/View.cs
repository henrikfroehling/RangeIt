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

        public static T[] Iota<T>(T startValue, uint count, Func<T, T> generator)
        {
            if (count == 0)
                return new T[0];

            var values = new T[count];
            var tmp = startValue;
            values[0] = tmp;

            for (int i = 1; i < count; ++i)
            {
                tmp = generator(tmp);
                values[i] = tmp;
            }

            return values;
        }

        public static T[] Iota<T>(T startValue, uint count, Func<T> generator)
        {
            if (count == 0)
                return new T[0];

            var values = new T[count];
            var tmp = startValue;
            values[0] = tmp;

            for (int i = 1; i < count; ++i)
            {
                tmp = generator();
                values[i] = tmp;
            }

            return values;
        }
    }
}
