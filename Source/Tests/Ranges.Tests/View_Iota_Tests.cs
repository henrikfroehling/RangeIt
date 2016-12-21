namespace Ranges.Tests
{
    using FluentAssertions;
    using System;
    using Xunit;

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
    }
}
