﻿namespace RangeIt.Tests.Iterators
{
    using FluentAssertions;
    using RangeIt.Iterators;
    using Xunit;

    [Collection("Iterator.Tests")]
    public class Iterator_Tests
    {
        [Fact]
        public void Test_Iterator_IsNot_Abstract()
        {
            typeof(Iterator).IsAbstract.Should().BeFalse();
        }

        [Fact]
        public void Test_Iterator_Is_Sealed()
        {
            typeof(Iterator).IsSealed.Should().BeTrue();
        }
    }
}