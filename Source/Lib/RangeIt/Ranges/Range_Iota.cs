namespace RangeIt.Ranges
{
    using System;
    using System.Collections.Generic;

    public static partial class Range
    {
        public static IEnumerable<int> Iota(int from, int to)
        {
            while (from < to)
                yield return from++;
        }

        public static IEnumerable<T> Iota<T>(T startValue, uint count, Func<T, T> generator)
        {
            var tmp = startValue;
            yield return tmp;

            for (int i = 1; i < count; ++i)
            {
                tmp = generator(tmp);
                yield return tmp;
            }
        }

        public static IEnumerable<T> Iota<T>(T startValue, uint count, Func<T> generator)
        {
            var tmp = startValue;
            yield return tmp;

            for (int i = 1; i < count; ++i)
                yield return generator();
        }

        public static IEnumerable<T> Iota<T>(uint count, Func<T> generator)
        {
            for (int i = 0; i < count; ++i)
                yield return generator();
        }

        public static IEnumerable<T> Iota<T>(Func<T, T> generator, Func<T, bool> cancellationPredicate)
        {
            var tmp = default(T);

            while (!cancellationPredicate(tmp))
            {
                tmp = generator(tmp);
                yield return tmp;
            }
        }

        public static IEnumerable<T> Iota<T>(T startValue, Func<T, T> generator, Func<T, bool> cancellationPredicate)
        {
            var tmp = startValue;
            yield return tmp;

            while (!cancellationPredicate(tmp))
            {
                tmp = generator(tmp);
                yield return tmp;
            }
        }
    }
}
