namespace Ranges
{
    using System;
    using System.Collections.Generic;

    public static partial class Functional
    {
        public static IEnumerable<int> iota(int from, int to) => Range.Iota(from, to);

        public static IEnumerable<T> iota<T>(T startValue, uint count, Func<T, T> generator) => Range.Iota(startValue, count, generator);

        public static IEnumerable<T> iota<T>(T startValue, uint count, Func<T> generator) => Range.Iota(startValue, count, generator);

        public static IEnumerable<T> iota<T>(uint count, Func<T> generator) => Range.Iota(count, generator);

        public static IEnumerable<T> iota<T>(Func<T, T> generator, Func<T, bool> cancellationPredicate) => Range.Iota(generator, cancellationPredicate);

        public static IEnumerable<T> iota<T>(T startValue, Func<T, T> generator, Func<T, bool> cancellationPredicate) => Range.Iota(startValue, generator, cancellationPredicate);
    }
}
