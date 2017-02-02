namespace RangeIt.Ranges.RangeStrategies
{
    using System;
    using System.Collections.Generic;

    internal interface IRangeStrategy<T> : IEnumerable<T>, IEquatable<IRangeStrategy<T>>
    {

    }
}
