namespace RangeIt.Iterators
{
    using Adapters.Const;
    using Interfaces;
    using Interfaces.Adapters;
    using System.Collections;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    /// <summary>
    /// A helper class for iterating forwards and backward through a collection
    /// and manipulating its elements.
    /// <para />
    /// Changing the size of the underlying collection, while the iterator is used,
    /// leads to undefined behavior.
    /// </summary>
    /// <typeparam name="T">The element type of the underlying collection.</typeparam>
    public struct ConstIterator<T> : IConstIterator<T>, IIterable, IEnumerable<T>
    {
        private readonly IConstIteratorAdapter<T> _iteratorAdapter;

        /// <summary>Initializes a new instance of the <see cref="ConstIterator{T}" /> struct.</summary>
        /// <param name="array">The array, for which this instance will be created.</param>
        public ConstIterator(T[] array)
        {
            _iteratorAdapter = new ArrayConstIteratorAdapter<T>(array);
        }

        internal ConstIterator(T[] array, bool isEnd)
        {
            _iteratorAdapter = new ArrayConstIteratorAdapter<T>(array, isEnd);
        }

        /// <summary>Initializes a new instance of the <see cref="ConstIterator{T}" /> struct.</summary>
        /// <param name="list">The list, for which this instance will be created.</param>
        public ConstIterator(List<T> list)
        {
            _iteratorAdapter = new ListConstIteratorAdapter<T>(list);
        }

        internal ConstIterator(List<T> list, bool isEnd)
        {
            _iteratorAdapter = new ListConstIteratorAdapter<T>(list, isEnd);
        }

        /// <summary>Initializes a new instance of the <see cref="ConstIterator{T}" /> struct.</summary>
        /// <param name="collection">The collection, for which this instance will be created.</param>
        public ConstIterator(Collection<T> collection)
        {
            _iteratorAdapter = new CollectionConstIteratorAdapter<T>(collection);
        }

        internal ConstIterator(Collection<T> collection, bool isEnd)
        {
            _iteratorAdapter = new CollectionConstIteratorAdapter<T>(collection, isEnd);
        }

        /// <summary>Initializes a new instance of the <see cref="ConstIterator{T}" /> struct.</summary>
        /// <param name="collection">The read only collection, for which this instance will be created.</param>
        public ConstIterator(ReadOnlyCollection<T> collection)
        {
            _iteratorAdapter = new ReadOnlyCollectionConstIteratorAdapter<T>(collection);
        }

        internal ConstIterator(ReadOnlyCollection<T> collection, bool isEnd)
        {
            _iteratorAdapter = new ReadOnlyCollectionConstIteratorAdapter<T>(collection, isEnd);
        }

        /// <summary>Returns the value of the element at the current iterator position.</summary>
        public T Current => _iteratorAdapter.Current;

        /// <summary>Returns the index of the current position of the iterator.</summary>
        public int Index => _iteratorAdapter.Index;

        /// <summary>Returns, whether the iterator is positioned after the last element in the collection.</summary>
        public bool IsEndIterator => _iteratorAdapter.IsEndIterator;

        /// <summary>Returns, whether the iterator is positioned at a valid position in the collection.</summary>
        public bool IsValid => _iteratorAdapter.IsValid;

        /// <summary>
        /// Moves the iterator one position backward, if possible.
        /// <para />
        /// See also <seealso cref="operator --(ConstIterator{T})" />.
        /// </summary>
        /// <returns>True, if iterator was moved, otherwise false.</returns>
        public bool Previous() => _iteratorAdapter.Previous();

        /// <summary>
        /// Moves the iterator one position forwards, if possible.
        /// <para />
        /// See also <seealso cref="operator ++(ConstIterator{T})" />.
        /// </summary>
        /// <returns>True, if iterator was moved, otherwise false.</returns>
        public bool Next() => _iteratorAdapter.Next();

        /// <summary>Returns a <see cref="IEnumerator{T}" /> for the underlying collection.</summary>
        /// <returns>A <see cref="IEnumerator{T}" />.</returns>
        public IEnumerator<T> GetEnumerator() => _iteratorAdapter.GetEnumerator();

        /// <summary>Returns a <see cref="IEnumerator" /> for the underlying collection.</summary>
        /// <returns>A <see cref="IEnumerator" />.</returns>
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        /// <summary>
        /// Returns a string that represents the current position of the iterator.
        /// <para />
        /// See also <seealso cref="Current" />.
        /// </summary>
        /// <returns>A string representing the current position of the iterator.</returns>
        public override string ToString() => Current?.ToString();

        /// <summary>
        /// Moves the given iterator one position backward, if possible.
        /// <para />
        /// See also <seealso cref="Previous()" />.
        /// </summary>
        /// <param name="it">The iterator, which will be moved by one position.</param>
        /// <returns>True, if the given iterator was moved, otherwise false.</returns>
        public static ConstIterator<T> operator --(ConstIterator<T> it)
        {
            it.Previous();
            return it;
        }

        /// <summary>
        /// Moves the given iterator one position forwards, if possible.
        /// <para />
        /// See also <seealso cref="Next()" />.
        /// </summary>
        /// <param name="it">The iterator, which will be moved by one position.</param>
        /// <returns>True, if the given iterator was moved, otherwise false.</returns>
        public static ConstIterator<T> operator ++(ConstIterator<T> it)
        {
            it.Next();
            return it;
        }

        /// <summary>
        /// Moves the given iterator a given number of positions backward, if possible.
        /// <para />
        /// See also <seealso cref="Previous()" />.
        /// </summary>
        /// <param name="it">The iterator, which will be moved <paramref name="count"/> positions.</param>
        /// <param name="count">The number of positions the iterator will be moved.</param>
        /// <returns>The moved iterator. No new instance will be created.</returns>
        public static ConstIterator<T> operator -(ConstIterator<T> it, int count)
        {
            for (int i = count; i > 0; --i)
            {
                if (!it.Previous())
                    break;
            }

            return it;
        }

        /// <summary>
        /// Moves the given iterator a given number of positions forwards, if possible.
        /// <para />
        /// See also <seealso cref="Previous()" />.
        /// </summary>
        /// <param name="it">The iterator, which will be moved <paramref name="count"/> positions.</param>
        /// <param name="count">The number of positions the iterator will be moved.</param>
        /// <returns>The moved iterator. No new instance will be created.</returns>
        public static ConstIterator<T> operator +(ConstIterator<T> it, int count)
        {
            for (int i = 0; i < count; ++i)
            {
                if (!it.Next())
                    break;
            }

            return it;
        }

        /// <summary>
        /// Returns, whether the iterator is positioned at a valid position in the collection.
        /// <para />
        /// See also <seealso cref="IsValid" />.
        /// </summary>
        /// <param name="it"></param>
        public static implicit operator bool(ConstIterator<T> it) => it.IsValid;

        /// <summary>
        /// Casts the iterator to the element type of its collection
        /// and returns the value of the current position.
        /// <para />
        /// See also <see cref="Current" />.
        /// </summary>
        /// <param name="it"></param>
        public static explicit operator T(ConstIterator<T> it) => it.Current;
    }
}
