namespace RangeIt.Tests.Ranges
{
    using FluentAssertions;
    using RangeIt.Ranges;
    using Xunit;

    [Collection("Range.Ints.Tests")]
    public class Range_Ints_Tests
    {
        [Fact]
        public void Test_Range_Ints()
        {
            var range = Range.Ints(10);

            range.Should().NotBeNull()
                          .And.NotBeEmpty()
                          .And.HaveCount(10)
                          .And.ContainInOrder(1, 2, 3, 4, 5, 6, 7, 8, 9, 10);
        }

        [Fact]
        public void Test_Range_Ints_WithZeroCount()
        {
            var range = Range.Ints(0);
            range.Should().NotBeNull().And.BeEmpty();
        }

        [Fact]
        public void Test_Range_Ints_WithStartValue()
        {
            var range = Range.Ints(5, 10);

            range.Should().NotBeNull()
                          .And.NotBeEmpty()
                          .And.HaveCount(10)
                          .And.ContainInOrder(5, 6, 7, 8, 9, 10, 11, 12, 13, 14);
        }
    }
}
