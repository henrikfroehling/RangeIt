namespace Ranges.Tests
{
    using FluentAssertions;
    using Xunit;

    public class View_Ints_Tests
    {
        [Fact]
        public void Test_View_Ints()
        {
            var range = View.Ints(10);

            range.Should().NotBeNull()
                          .And.NotBeEmpty()
                          .And.HaveCount(10)
                          .And.ContainInOrder(1, 2, 3, 4, 5, 6, 7, 8, 9, 10);
        }

        [Fact]
        public void Test_View_Ints_WithZeroCount()
        {
            var range = View.Ints(0);

            range.Should().NotBeNull()
                          .And.BeEmpty()
                          .And.HaveCount(0);
        }

        [Fact]
        public void Test_View_Ints_WithStartValue()
        {
            var range = View.Ints(5, 10);

            range.Should().NotBeNull()
                          .And.NotBeEmpty()
                          .And.HaveCount(10)
                          .And.ContainInOrder(5, 6, 7, 8, 9, 10, 11, 12, 13, 14);
        }
    }
}
