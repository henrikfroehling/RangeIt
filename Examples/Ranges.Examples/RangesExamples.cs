namespace Ranges.Examples
{
    using RangeIt.Ranges;
    using System;

    internal static class RangesExamples
    {
        internal static void Main(string[] args)
        {
            RangeInts();
            RangeIota();
            RangeLooping();
            RangeTransform();
            RangeFilter();
        }

        internal static void RangeInts()
        {
            const uint count = 10;
            const int start = 5;
            const int step = 2;

            Console.WriteLine("------------------------------------");
            Console.WriteLine("---------- Range.Ints() ------------");
            Console.WriteLine("------------------------------------");

            Range<int> intRange = Range.Ints(count);
            Console.WriteLine($"Integer Range (Count = {count}): {intRange}");

            // with start value
            intRange = Range.Ints(start, count);
            Console.WriteLine($"Integer Range (Count = {count}, Start = {start}): {intRange}");

            // with step value
            intRange = Range.IntsWithStep(count, step);
            Console.WriteLine($"Integer Range (Count = {count}, Step = {step}): {intRange}");

            // with start value / with step value
            intRange = Range.Ints(start, count, step);
            Console.WriteLine($"Integer Range (Count = {count}, Start = {start}, Step = {step}): {intRange}");
        }

        internal static void RangeIota()
        {
            const int from = 5;
            const int to = 20;
            const int step = 2;

            Console.WriteLine("------------------------------------");
            Console.WriteLine("---------- Range.Iota() ------------");
            Console.WriteLine("------------------------------------");

            Range<int> intRange = Range.Iota(from, to);
            Console.WriteLine($"Integer Range (From = {from}, To = {to}): {intRange}");

            intRange = Range.Iota(from, to, step);
            Console.WriteLine($"Integer Range (From = {from}, To = {to}, Step = {step}): {intRange}");

            const string startValue = "hello";
            const int maxLength = 10;

            Range<string> stringRange = Range.Iota(startValue, (s) => s + "a", (s) => s?.Length == maxLength);
            Console.WriteLine($"String Range (StartValue = {startValue}, MaxLength = {maxLength}): {stringRange}");
        }

        internal static void RangeLooping()
        {
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("---------- Range - Looping ------------");
            Console.WriteLine("---------------------------------------");

            foreach (var val in Range.Ints(10))
                Console.Write($"{val} ");

            Console.Write("\n");
        }

        internal static void RangeTransform()
        {
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("---------- Range - Transform ------------");
            Console.WriteLine("-----------------------------------------");

            Range<int> intRange = Range.Ints(10);
            Console.WriteLine($"Integer Range: {intRange}");

            intRange = intRange.Transform(Range.MultiplyBy(2));
            Console.WriteLine($"Integer Range (each element multiplied by 2): {intRange}");

            intRange |= Range.MultiplyBy(4);
            Console.WriteLine($"Integer Range (each element multiplied by 4): {intRange}");

            intRange = intRange.Transform((i) => i + 2);
            Console.WriteLine($"Integer Range (each element incremented by 2): {intRange}");

            intRange |= (i) => i + 4;
            Console.WriteLine($"Integer Range (each element incremented by 4): {intRange}");
        }

        internal static void RangeFilter()
        {
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("---------- Range - Filter ------------");
            Console.WriteLine("--------------------------------------");

            Range<int> intRange = Range.Ints(10);
            Console.WriteLine($"Integer Range: {intRange}");

            intRange = intRange.Filter(Range.IsEven());
            Console.WriteLine($"Integer Range (only even numbers): {intRange}");

            intRange |= (i) => i % 4 == 0;
            Console.WriteLine($"Integer Range (only numbers divisible by 4): {intRange}");

            Console.WriteLine("--------------------------------------");

            intRange = Range.Ints(10);
            Console.WriteLine($"Integer Range: {intRange}");

            intRange |= Range.IsEven();
            Console.WriteLine($"Integer Range (only even numbers): {intRange}");
        }
    }
}
