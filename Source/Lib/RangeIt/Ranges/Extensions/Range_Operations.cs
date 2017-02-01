namespace RangeIt.Ranges
{
    using System;

    public static partial class Range
    {
        public static Range<T> Filter<T>(this Range<T> range, Func<T, bool> function)
            => range |= function;

        public static Range<T> Transform<T>(this Range<T> range, Func<T, T> function)
            => range |= function;
    }
}
