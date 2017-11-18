namespace RangeIt.Tests.Ranges
{
    using FluentAssertions;
    using RangeIt.Ranges;
    using Traits;
    using Xunit;

    public class Range_Functions_Tests
    {
        [Fact]
        [Category("Ranges.Range.Functions.Multiply")]
        public void Test_Range_Functions_Multiply()
        {
            Range<int> range = Range.Ints(10);

            range.Should().NotBeNull()
                          .And.NotBeEmpty()
                          .And.HaveCount(10)
                          .And.ContainInOrder(1, 2, 3, 4, 5, 6, 7, 8, 9, 10);

            range = range.Transform(Range.MultiplyBy(2));

            range.Should().NotBeNull()
                          .And.NotBeEmpty()
                          .And.HaveCount(10)
                          .And.ContainInOrder(2, 4, 6, 8, 10, 12, 14, 16, 18, 20);
        }

        [Fact]
        [Category("Ranges.Range.Functions.Multiply.OperatorOverload")]
        public void Test_Range_Functions_Multiply_OperatorOverload()
        {
            Range<int> range = Range.Ints(10);

            range.Should().NotBeNull()
                          .And.NotBeEmpty()
                          .And.HaveCount(10)
                          .And.ContainInOrder(1, 2, 3, 4, 5, 6, 7, 8, 9, 10);

            range |= Range.MultiplyBy(2);

            range.Should().NotBeNull()
                          .And.NotBeEmpty()
                          .And.HaveCount(10)
                          .And.ContainInOrder(2, 4, 6, 8, 10, 12, 14, 16, 18, 20);
        }

        [Fact]
        [Category("Ranges.Range.Functions.IsEven")]
        public void Test_Range_Functions_IsEven()
        {
            Range<int> range = Range.Ints(10);

            range.Should().NotBeNull()
                          .And.NotBeEmpty()
                          .And.HaveCount(10)
                          .And.ContainInOrder(1, 2, 3, 4, 5, 6, 7, 8, 9, 10);

            range = range.Filter(Range.IsEven());

            range.Should().NotBeNull()
                          .And.NotBeEmpty()
                          .And.HaveCount(5)
                          .And.ContainInOrder(2, 4, 6, 8, 10);
        }

        [Fact]
        [Category("Ranges.Range.Functions.IsEven.OperatorOverload")]
        public void Test_Range_Functions_IsEven_OperatorOverload()
        {
            Range<int> range = Range.Ints(10);

            range.Should().NotBeNull()
                          .And.NotBeEmpty()
                          .And.HaveCount(10)
                          .And.ContainInOrder(1, 2, 3, 4, 5, 6, 7, 8, 9, 10);

            range |= Range.IsEven();

            range.Should().NotBeNull()
                          .And.NotBeEmpty()
                          .And.HaveCount(5)
                          .And.ContainInOrder(2, 4, 6, 8, 10);
        }

        [Fact]
        [Category("Ranges.Range.Functions.IsOdd")]
        public void Test_Range_Functions_IsOdd()
        {
            Range<int> range = Range.Ints(10);

            range.Should().NotBeNull()
                          .And.NotBeEmpty()
                          .And.HaveCount(10)
                          .And.ContainInOrder(1, 2, 3, 4, 5, 6, 7, 8, 9, 10);

            range = range.Filter(Range.IsOdd());

            range.Should().NotBeNull()
                          .And.NotBeEmpty()
                          .And.HaveCount(5)
                          .And.ContainInOrder(1, 3, 5, 7, 9);
        }

        [Fact]
        [Category("Ranges.Range.Functions.IsOdd.OperatorOverload")]
        public void Test_Range_Functions_IsOdd_OperatorOverload()
        {
            Range<int> range = Range.Ints(10);

            range.Should().NotBeNull()
                          .And.NotBeEmpty()
                          .And.HaveCount(10)
                          .And.ContainInOrder(1, 2, 3, 4, 5, 6, 7, 8, 9, 10);

            range |= Range.IsOdd();

            range.Should().NotBeNull()
                          .And.NotBeEmpty()
                          .And.HaveCount(5)
                          .And.ContainInOrder(1, 3, 5, 7, 9);
        }
    }
}
