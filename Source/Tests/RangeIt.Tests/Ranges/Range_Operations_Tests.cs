namespace RangeIt.Tests.Ranges
{
    using FluentAssertions;
    using RangeIt.Ranges;
    using Traits;
    using Xunit;

    public class Range_Operations_Tests
    {
        [Fact]
        [Category("Ranges.Range.Operations.Transform")]
        public void Test_Range_Operation_Transform()
        {
            var range = Range.Ints(10);

            range.Should().NotBeNull()
                          .And.NotBeEmpty()
                          .And.HaveCount(10)
                          .And.ContainInOrder(1, 2, 3, 4, 5, 6, 7, 8, 9, 10);

            range = range.Transform((i) => i * 2);

            range.Should().NotBeNull()
                          .And.NotBeEmpty()
                          .And.HaveCount(10)
                          .And.ContainInOrder(2, 4, 6, 8, 10, 12, 14, 16, 18, 20);
        }

        [Fact]
        [Category("Ranges.Range.Operations.Transform.OperatorOverload")]
        public void Test_Range_Operation_Transform_OperatorOverload()
        {
            var range = Range.Ints(10);

            range.Should().NotBeNull()
                          .And.NotBeEmpty()
                          .And.HaveCount(10)
                          .And.ContainInOrder(1, 2, 3, 4, 5, 6, 7, 8, 9, 10);

            range |= (i) => i * 2;

            range.Should().NotBeNull()
                          .And.NotBeEmpty()
                          .And.HaveCount(10)
                          .And.ContainInOrder(2, 4, 6, 8, 10, 12, 14, 16, 18, 20);
        }

        [Fact]
        [Category("Ranges.Range.Operations.Filter")]
        public void Test_Range_Operation_Filter()
        {
            var range = Range.Ints(10);

            range.Should().NotBeNull()
                          .And.NotBeEmpty()
                          .And.HaveCount(10)
                          .And.ContainInOrder(1, 2, 3, 4, 5, 6, 7, 8, 9, 10);

            range = range.Filter((i) => i % 2 == 0);

            range.Should().NotBeNull()
                          .And.NotBeEmpty()
                          .And.HaveCount(5)
                          .And.ContainInOrder(2, 4, 6, 8, 10);
        }

        [Fact]
        [Category("Ranges.Range.Operations.Filter.OperatorOverload")]
        public void Test_Range_Operation_Filter_OperatorOverload()
        {
            var range = Range.Ints(10);

            range.Should().NotBeNull()
                          .And.NotBeEmpty()
                          .And.HaveCount(10)
                          .And.ContainInOrder(1, 2, 3, 4, 5, 6, 7, 8, 9, 10);

            range |= (i) => i % 2 == 0;

            range.Should().NotBeNull()
                          .And.NotBeEmpty()
                          .And.HaveCount(5)
                          .And.ContainInOrder(2, 4, 6, 8, 10);
        }
    }
}
