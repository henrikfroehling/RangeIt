namespace Ranges.Tests
{
    using FluentAssertions;
    using System;
    using Xunit;

    [Collection("View.Iota.Tests")]
    public class View_Iota_Tests
    {
        [Fact]
        public void Test_View_Iota()
        {
            var range = View.Iota(1, 11);

            range.Should().NotBeNull()
                          .And.NotBeEmpty()
                          .And.HaveCount(10)
                          .And.ContainInOrder(1, 2, 3, 4, 5, 6, 7, 8, 9, 10);
        }

        [Fact]
        public void Test_View_Iota_With_To_SmallerThan_From()
        {
            Action act = () => View.Iota(1, 0);
            act.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Fact]
        public void Test_View_Iota_WithEqualArguments()
        {
            var range = View.Iota(1, 1);

            range.Should().NotBeNull()
                          .And.BeEmpty()
                          .And.HaveCount(0);
        }

        [Fact]
        public void Test_View_Iota_WithFunctor_WithStartValue_IntIteration()
        {
            var range = View.Iota(1, 10, (i) => i + 1);

            range.Should().NotBeNull()
                          .And.NotBeEmpty()
                          .And.HaveCount(10)
                          .And.ContainInOrder(1, 2, 3, 4, 5, 6, 7, 8, 9, 10);
        }

        [Fact]
        public void Test_View_Iota_WithFunctor_WithStartValue_NegativeIntIteration()
        {
            var range = View.Iota(1, 10, (i) => i - 1);

            range.Should().NotBeNull()
                          .And.NotBeEmpty()
                          .And.HaveCount(10)
                          .And.ContainInOrder(1, 0, -1, -2, -3, -4, -5, -6, -7, -8);
        }

        [Fact]
        public void Test_View_Iota_WithFunctor_WithStartValue_IntMultiplications()
        {
            var range = View.Iota(1, 10, (i) => i * 2);

            range.Should().NotBeNull()
                          .And.NotBeEmpty()
                          .And.HaveCount(10)
                          .And.ContainInOrder(1, 2, 4, 8, 16, 32, 64, 128, 256, 512);
        }

        [Fact]
        public void Test_View_Iota_WithFunctor_WithStartValue_NegativeIntMultiplications()
        {
            var range = View.Iota(1, 10, (i) => i * -2);

            range.Should().NotBeNull()
                          .And.NotBeEmpty()
                          .And.HaveCount(10)
                          .And.ContainInOrder(1, -2, 4, -8, 16, -32, 64, -128, 256, -512);
        }

        [Fact]
        public void Test_View_Iota_WithFunctor_WithStartValue_StringIteration()
        {
            var range = View.Iota("a", 10, (s) => s + "a");

            range.Should().NotBeNull()
                          .And.NotBeEmpty()
                          .And.HaveCount(10)
                          .And.ContainInOrder("a", "aa", "aaa", "aaaa", "aaaaa",
                                              "aaaaaa", "aaaaaaa", "aaaaaaaa",
                                              "aaaaaaaaa", "aaaaaaaaaa");
        }

        [Fact]
        public void Test_View_Iota_WithFunctor_WithStartValue_WithZeroCount()
        {
            var range = View.Iota(1, 0, (i) => i + 1);

            range.Should().NotBeNull()
                          .And.BeEmpty()
                          .And.HaveCount(0);
        }

        [Fact]
        public void Test_View_Iota_WithSimpleFunctor_WithStartValue_Ints()
        {
            var range = View.Iota(1, 10, () => 5 * 5);

            range.Should().NotBeNull()
                          .And.NotBeEmpty()
                          .And.HaveCount(10)
                          .And.ContainInOrder(1, 25, 25, 25, 25, 25, 25, 25, 25, 25);
        }

        [Fact]
        public void Test_View_Iota_WithSimpleFunctor_WithStartValue_Strings()
        {
            var range = View.Iota("hello", 10, () => "world");

            range.Should().NotBeNull()
                          .And.NotBeEmpty()
                          .And.HaveCount(10)
                          .And.ContainInOrder("hello", "world", "world", "world", "world",
                                              "world", "world", "world", "world", "world");
        }

        [Fact]
        public void Test_View_Iota_WithSimpleFunctor_WithStartValue_WithZeroCount()
        {
            var range = View.Iota(1, 0, () => 1);

            range.Should().NotBeNull()
                          .And.BeEmpty()
                          .And.HaveCount(0);
        }
    }
}
