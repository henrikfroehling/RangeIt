namespace RangeIt.Tests.Ranges
{
    using FluentAssertions;
    using RangeIt.Ranges;
    using Traits;
    using Xunit;

    [Collection("Range.Ints.Tests")]
    public class Range_Ints_Tests
    {
        [Fact]
        [Category("Ranges.Range.Ints")]
        public void Test_Range_Ints()
        {
            var range = Range.Ints(10);

            range.Should().NotBeNull()
                          .And.NotBeEmpty()
                          .And.HaveCount(10)
                          .And.ContainInOrder(1, 2, 3, 4, 5, 6, 7, 8, 9, 10);
        }

        [Fact]
        [Category("Ranges.Range.Ints")]
        public void Test_Range_Ints_WithZeroCount()
        {
            var range = Range.Ints(0);
            range.Should().NotBeNull().And.BeEmpty();
        }

        [Fact]
        [Category("Ranges.Range.Ints.WithStep")]
        public void Test_Range_Ints_WithStep()
        {
            var range = Range.IntsWithStep(10, 2);

            range.Should().NotBeNull()
                          .And.NotBeEmpty()
                          .And.HaveCount(10)
                          .And.ContainInOrder(1, 3, 5, 7, 9, 11, 13, 15, 17, 19);
        }

        [Fact]
        [Category("Ranges.Range.Ints.WithStep")]
        public void Test_Range_Ints_WithZeroStep()
        {
            var range = Range.IntsWithStep(10, 0);

            range.Should().NotBeNull()
                          .And.NotBeEmpty()
                          .And.HaveCount(10)
                          .And.ContainInOrder(1, 1, 1, 1, 1, 1, 1, 1, 1, 1);
        }

        [Fact]
        [Category("Ranges.Range.Ints.WithStep")]
        public void Test_Range_Ints_WithStep_WithZeroCount()
        {
            var range = Range.IntsWithStep(0, 2);
            range.Should().NotBeNull().And.BeEmpty();
        }

        [Fact]
        [Category("Ranges.Range.Ints.WithStartValue")]
        public void Test_Range_Ints_WithStartValue()
        {
            var range = Range.Ints(5, 10);

            range.Should().NotBeNull()
                          .And.NotBeEmpty()
                          .And.HaveCount(10)
                          .And.ContainInOrder(5, 6, 7, 8, 9, 10, 11, 12, 13, 14);
        }

        [Fact]
        [Category("Ranges.Range.Ints.WithStartValue")]
        public void Test_Range_Ints_WithStartValue_WithZeroCount()
        {
            var range = Range.Ints(5, 0);
            range.Should().NotBeNull().And.BeEmpty();
        }

        [Fact]
        [Category("Ranges.Range.Ints.WithStartValue")]
        public void Test_Range_Ints_WithStartValue_WithStep()
        {
            var range = Range.Ints(5, 10, 2);

            range.Should().NotBeNull()
                          .And.NotBeEmpty()
                          .And.HaveCount(10)
                          .And.ContainInOrder(5, 7, 9, 11, 13, 15, 17, 19, 21, 23);
        }

        [Fact]
        [Category("Ranges.Range.Ints.WithStartValue")]
        public void Test_Range_Ints_WithStartValue_WithStep_WithZeroCount()
        {
            var range = Range.Ints(5, 0, 2);
            range.Should().NotBeNull().And.BeEmpty();
        }
    }
}
