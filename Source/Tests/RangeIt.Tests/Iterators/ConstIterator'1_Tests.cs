﻿namespace RangeIt.Tests.Iterators
{
    using FluentAssertions;
    using RangeIt.Iterators;
    using Xunit;

    [Collection("ConstIterator<T>.Tests")]
    public class ConstIterator_1_Tests
    {
        [Fact]
        public void Test_ConstIterator_1_IsNot_Abstract()
        {
            typeof(ConstIterator<>).IsAbstract.Should().BeFalse();
        }

        [Fact]
        public void Test_ConstIterator_1_Is_Sealed()
        {
            typeof(ConstIterator<>).IsSealed.Should().BeTrue();
        }

        [Fact]
        public void Test_ConstIterator_1_Is_Generic()
        {
            typeof(ConstIterator<>).ContainsGenericParameters.Should().BeTrue();
            typeof(ConstIterator<int>).GenericTypeArguments.Should().NotBeEmpty().And.HaveCount(1);
        }
    }
}