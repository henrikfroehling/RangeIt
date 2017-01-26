namespace RangeIt.Ranges
{
    using System;
    using System.Collections.Generic;

    public static partial class Range
    {
        /// <summary>Generates a range [from, to) containing sequential and distinct integers.</summary>
        /// <param name="from">The start value, at which the generated range starts.</param>
        /// <param name="to">
        /// The stop value, at which the generated range stops.
        /// This value is not included in the generated range.
        /// </param>
        /// <returns>
        /// A <see cref="IEnumerable{T}" /> of ints, containing the generated integers.
        /// If <paramref name="from"/> and <paramref name="to" /> are equal,
        /// or if <paramref name="from" /> is greater than <paramref name="to" />,
        /// the returned <see cref="IEnumerable{T}" /> will be empty.
        /// </returns>
        public static IEnumerable<int> Iota(int from, int to) => Iota(from, to, 1);

        /// <summary>Generates a range [from, to) containing sequential and distinct integers.</summary>
        /// <param name="from">The start value, at which the generated range starts.</param>
        /// <param name="to">
        /// The stop value, at which the generated range stops.
        /// This value is not included in the generated range.
        /// </param>
        /// <param name="step">
        /// The difference between two sequential values in the generated range.
        /// <para />
        /// If this value is negative, it will be converted into a positive value.
        /// If this value is 0, it will be incremented to 1.
        /// </param>
        /// <returns>
        /// A <see cref="IEnumerable{T}" /> of ints, containing the generated integers.
        /// If <paramref name="from"/> and <paramref name="to" /> are equal,
        /// or if <paramref name="from" /> is greater than <paramref name="to" />,
        /// the returned <see cref="IEnumerable{T}" /> will be empty.
        /// </returns>
        public static IEnumerable<int> Iota(int from, int to, int step)
        {
            if (step < 0)
                step = step * -1;
            else if (step == 0)
                step = 1;

            while (from < to)
            {
                yield return from;
                from += step;
            }
        }

        /// <summary>
        /// Generates a range containing a given number of elements of type <typeparamref name="T" />.
        /// <para />
        /// If <paramref name="count"/> is 0, the returned <see cref="IEnumerable{T}" />
        /// contains the given <paramref name="startValue" /> as the one and only element.
        /// </summary>
        /// <typeparam name="T">The type of the elements in the range.</typeparam>
        /// <param name="startValue">A start value, as the first element in the generated range.</param>
        /// <param name="count">
        /// The number of elements, which will be generated,
        /// including the given <paramref name="startValue" />.
        /// </param>
        /// <param name="generator">
        /// A generator function, which generates a new element of type
        /// <typeparamref name="T" />. Takes the previous element in the range as an argument.
        /// </param>
        /// <returns>A <see cref="IEnumerable{T}" />, containing the generated elements.</returns>
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

        /// <summary>
        /// Generates a range containing a given number of elements of type <typeparamref name="T" />.
        /// <para />
        /// If <paramref name="count"/> is 0, the returned <see cref="IEnumerable{T}" />
        /// contains the given <paramref name="startValue" /> as the one and only element.
        /// </summary>
        /// <typeparam name="T">The type of the elements in the range.</typeparam>
        /// <param name="startValue">A start value, as the first element in the generated range.</param>
        /// <param name="count">
        /// The number of elements, which will be generated,
        /// including the given <paramref name="startValue" />.
        /// </param>
        /// <param name="generator">A generator function, which generates a new element of type
        /// <typeparamref name="T" />.</param>
        /// <returns>A <see cref="IEnumerable{T}" />, containing the generated elements.</returns>
        public static IEnumerable<T> Iota<T>(T startValue, uint count, Func<T> generator)
        {
            var tmp = startValue;
            yield return tmp;

            for (int i = 1; i < count; ++i)
                yield return generator();
        }

        /// <summary>Generates a range containing a given number of elements of type <typeparamref name="T" />.</summary>
        /// <typeparam name="T">The type of the elements in the range.</typeparam>
        /// <param name="count">The number of elements, which will be generated.</param>
        /// <param name="generator">A generator function, which generates a new element of type
        /// <typeparamref name="T" />.</param>
        /// <returns>
        /// A <see cref="IEnumerable{T}" />, containing the generated elements.
        /// If <paramref name="count"/> is 0, the returned <see cref="IEnumerable{T}" /> will be empty.
        /// </returns>
        public static IEnumerable<T> Iota<T>(uint count, Func<T> generator)
        {
            for (int i = 0; i < count; ++i)
                yield return generator();
        }

        /// <summary>
        /// Generates a range containing elements of type <typeparamref name="T" />.
        /// Elements will be generated as long as the given <paramref name="cancellationPredicate" />
        /// returns false.
        /// <para />
        /// The first element in the range will be generated with default(<typeparamref name="T" />),
        /// therefore the argument in the given <paramref name="generator" /> function might be null.
        /// </summary>
        /// <typeparam name="T">The type of the elements in the range.</typeparam>
        /// <param name="generator">
        /// A generator function, which generates a new element of type
        /// <typeparamref name="T" />. Takes the previous element in the range as an argument.
        /// </param>
        /// <param name="cancellationPredicate">
        /// A predicate function, which takes the next with the given <paramref name="generator" />
        /// generated element as argument and returns true or false,
        /// indicating whether the range is complete or not.
        /// </param>
        /// <returns>A <see cref="IEnumerable{T}" />, containing the generated elements.</returns>
        public static IEnumerable<T> Iota<T>(Func<T, T> generator, Func<T, bool> cancellationPredicate)
        {
            var tmp = default(T);

            while (!cancellationPredicate(tmp))
            {
                tmp = generator(tmp);
                yield return tmp;
            }
        }

        /// <summary>
        /// Generates a range containing elements of type <typeparamref name="T" />.
        /// Elements will be generated as long as the given <paramref name="cancellationPredicate" />
        /// returns false.
        /// </summary>
        /// <typeparam name="T">The type of the elements in the range.</typeparam>
        /// <param name="startValue">A start value, as the first element in the generated range.</param>
        /// <param name="generator">
        /// A generator function, which generates a new element of type
        /// <typeparamref name="T" />. Takes the previous element in the range as an argument.
        /// </param>
        /// <param name="cancellationPredicate">
        /// A predicate function, which takes the next with the given <paramref name="generator" />
        /// generated element as argument and returns true or false,
        /// indicating whether the range is complete or not.
        /// </param>
        /// <returns>A <see cref="IEnumerable{T}" />, containing the generated elements.</returns>
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

        /// <summary>
        /// Generates a range containing elements of type <typeparamref name="T" />.
        /// Elements will be generated as long as the given <paramref name="cancellationPredicate" />
        /// returns false.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="generator">A generator function, which generates a new element of type
        /// <typeparamref name="T" />.</param>
        /// <param name="cancellationPredicate">
        /// A predicate function, which takes the next with the given <paramref name="generator" />
        /// generated element as argument and returns true or false,
        /// indicating whether the range is complete or not.
        /// </param>
        /// <returns>A <see cref="IEnumerable{T}" />, containing the generated elements.</returns>
        public static IEnumerable<T> Iota<T>(Func<T> generator, Func<T, bool> cancellationPredicate)
        {
            while (true)
            {
                var tmp = generator();
                yield return tmp;

                if (cancellationPredicate(tmp))
                    yield break;
            }
        }
    }
}
