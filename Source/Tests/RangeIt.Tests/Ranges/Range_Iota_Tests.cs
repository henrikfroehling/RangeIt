namespace RangeIt.Tests.Ranges
{
    using FluentAssertions;
    using RangeIt.Ranges;
    using System.Linq;
    using Traits;
    using Xunit;
    
    public class Range_Iota_Tests
    {
        [Fact]
        [Category("Ranges.Range.Iota")]
        public void Test_Range_Iota()
        {
            var range = Range.Iota(1, 11);

            range.Should().NotBeNull()
                          .And.NotBeEmpty()
                          .And.HaveCount(10)
                          .And.ContainInOrder(1, 2, 3, 4, 5, 6, 7, 8, 9, 10);
        }

        [Fact]
        [Category("Ranges.Range.Iota")]
        public void Test_Range_Iota_With_To_SmallerThan_From()
        {
            var range = Range.Iota(1, 0);
            range.Should().NotBeNull().And.BeEmpty();
        }

        [Fact]
        [Category("Ranges.Range.Iota")]
        public void Test_Range_Iota_WithEqualArguments()
        {
            var range = Range.Iota(1, 1);
            range.Should().NotBeNull().And.BeEmpty();
        }

        [Fact]
        [Category("Ranges.Range.Iota.WithStep")]
        public void Test_Range_Iota_WithStep()
        {
            var range = Range.Iota(1, 11, 2);

            range.Should().NotBeNull()
                          .And.NotBeEmpty()
                          .And.HaveCount(5)
                          .And.ContainInOrder(1, 3, 5, 7, 9);
        }

        [Fact]
        [Category("Ranges.Range.Iota.WithStep")]
        public void Test_Range_Iota_WithNegativeStep()
        {
            var range = Range.Iota(1, 11, -2);

            range.Should().NotBeNull()
                          .And.NotBeEmpty()
                          .And.HaveCount(5)
                          .And.ContainInOrder(1, 3, 5, 7, 9);
        }

        [Fact]
        [Category("Ranges.Range.Iota.WithStep")]
        public void Test_Range_Iota_WithZeroStep()
        {
            var range = Range.Iota(1, 11, 0);

            range.Should().NotBeNull()
                          .And.NotBeEmpty()
                          .And.HaveCount(10)
                          .And.ContainInOrder(1, 2, 3, 4, 5, 6, 7, 8, 9, 10);
        }

        [Fact]
        [Category("Ranges.Range.Iota.WithStep")]
        public void Test_Range_Iota_WithStep_With_To_SmallerThan_From()
        {
            var range = Range.Iota(1, 0, 2);
            range.Should().NotBeNull().And.BeEmpty();
        }

        [Fact]
        [Category("Ranges.Range.Iota.WithStep")]
        public void Test_Range_Iota_WithStep_WithEqualArguments()
        {
            var range = Range.Iota(1, 1, 2);
            range.Should().NotBeNull().And.BeEmpty();
        }

        [Fact]
        [Category("Ranges.Range.Iota.WithFunctor.WithStartValue")]
        public void Test_Range_Iota_WithFunctor_WithStartValue_IntIteration()
        {
            var range = Range.Iota(1, 10, (i) => i + 1);

            range.Should().NotBeNull()
                          .And.NotBeEmpty()
                          .And.HaveCount(10)
                          .And.ContainInOrder(1, 2, 3, 4, 5, 6, 7, 8, 9, 10);
        }

        [Fact]
        [Category("Ranges.Range.Iota.WithFunctor.WithStartValue")]
        public void Test_Range_Iota_WithFunctor_WithStartValue_NegativeIntIteration()
        {
            var range = Range.Iota(1, 10, (i) => i - 1);

            range.Should().NotBeNull()
                          .And.NotBeEmpty()
                          .And.HaveCount(10)
                          .And.ContainInOrder(1, 0, -1, -2, -3, -4, -5, -6, -7, -8);
        }

        [Fact]
        [Category("Ranges.Range.Iota.WithFunctor.WithStartValue")]
        public void Test_Range_Iota_WithFunctor_WithStartValue_IntMultiplications()
        {
            var range = Range.Iota(1, 10, (i) => i * 2);

            range.Should().NotBeNull()
                          .And.NotBeEmpty()
                          .And.HaveCount(10)
                          .And.ContainInOrder(1, 2, 4, 8, 16, 32, 64, 128, 256, 512);
        }

        [Fact]
        [Category("Ranges.Range.Iota.WithFunctor.WithStartValue")]
        public void Test_Range_Iota_WithFunctor_WithStartValue_NegativeIntMultiplications()
        {
            var range = Range.Iota(1, 10, (i) => i * -2);

            range.Should().NotBeNull()
                          .And.NotBeEmpty()
                          .And.HaveCount(10)
                          .And.ContainInOrder(1, -2, 4, -8, 16, -32, 64, -128, 256, -512);
        }

        [Fact]
        [Category("Ranges.Range.Iota.WithFunctor.WithStartValue")]
        public void Test_Range_Iota_WithFunctor_WithStartValue_StringIteration()
        {
            var range = Range.Iota("a", 10, (s) => s + "a");

            range.Should().NotBeNull()
                          .And.NotBeEmpty()
                          .And.HaveCount(10)
                          .And.ContainInOrder("a", "aa", "aaa", "aaaa", "aaaaa",
                                              "aaaaaa", "aaaaaaa", "aaaaaaaa",
                                              "aaaaaaaaa", "aaaaaaaaaa");
        }

        [Fact]
        [Category("Ranges.Range.Iota.WithFunctor.WithStartValue")]
        public void Test_Range_Iota_WithFunctor_WithStartValue_WithZeroCount()
        {
            var range = Range.Iota(1, 0, (i) => i + 1);

            range.Should().NotBeNull()
                          .And.NotBeEmpty()
                          .And.HaveCount(1)
                          .And.ContainInOrder(1);
        }

        [Fact]
        [Category("Ranges.Range.Iota.WithSimpleFunctor.WithStartValue")]
        public void Test_Range_Iota_WithSimpleFunctor_WithStartValue_Ints()
        {
            var range = Range.Iota(1, 10, () => 5 * 5);

            range.Should().NotBeNull()
                          .And.NotBeEmpty()
                          .And.HaveCount(10)
                          .And.ContainInOrder(1, 25, 25, 25, 25, 25, 25, 25, 25, 25);
        }

        [Fact]
        [Category("Ranges.Range.Iota.WithSimpleFunctor.WithStartValue")]
        public void Test_Range_Iota_WithSimpleFunctor_WithStartValue_Strings()
        {
            var range = Range.Iota("hello", 10, () => "world");

            range.Should().NotBeNull()
                          .And.NotBeEmpty()
                          .And.HaveCount(10)
                          .And.ContainInOrder("hello", "world", "world", "world", "world",
                                              "world", "world", "world", "world", "world");
        }

        [Fact]
        [Category("Ranges.Range.Iota.WithSimpleFunctor.WithStartValue")]
        public void Test_Range_Iota_WithSimpleFunctor_WithStartValue_WithZeroCount()
        {
            var range = Range.Iota(1, 0, () => 1);

            range.Should().NotBeNull()
                          .And.NotBeEmpty()
                          .And.HaveCount(1)
                          .And.ContainInOrder(1);
        }

        [Fact]
        [Category("Ranges.Range.Iota.WithSimpleFunctor")]
        public void Test_Range_Iota_WithSimpleFunctor_Ints()
        {
            var range = Range.Iota(10, () => 5 * 5);

            range.Should().NotBeNull()
                          .And.NotBeEmpty()
                          .And.HaveCount(10)
                          .And.ContainInOrder(25, 25, 25, 25, 25, 25, 25, 25, 25, 25);
        }

        [Fact]
        [Category("Ranges.Range.Iota.WithSimpleFunctor")]
        public void Test_Range_Iota_WithSimpleFunctor_Strings()
        {
            var range = Range.Iota(10, () => "hello");

            range.Should().NotBeNull()
                          .And.NotBeEmpty()
                          .And.HaveCount(10)
                          .And.ContainInOrder("hello", "hello", "hello", "hello", "hello",
                                              "hello", "hello", "hello", "hello", "hello");
        }

        [Fact]
        [Category("Ranges.Range.Iota.WithSimpleFunctor")]
        public void Test_Range_Iota_WithSimpleFunctor_WithZeroCount()
        {
            var range = Range.Iota(0, () => 1);
            range.Should().NotBeNull().And.BeEmpty();
        }

        [Fact]
        [Category("Ranges.Range.Iota.WithGenerator")]
        public void Test_Range_Iota_WithGenerator_Ints()
        {
            // startValue is 0 (excluding)
            var range = Range.Iota<int>((i) => i + 1, (i) => i == 15);

            range.Should().NotBeNull()
                          .And.NotBeEmpty()
                          .And.HaveCount(15)
                          .And.ContainInOrder(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15);
        }

        [Fact]
        [Category("Ranges.Range.Iota.WithGenerator")]
        public void Test_Range_Iota_WithGenerator_Strings()
        {
            // startValue is null (excluding)
            var range = Range.Iota<string>((s) => s != null ? s + "a" : "a",
                                           (s) => s?.Length == 10);

            range.Should().NotBeNull()
                          .And.NotBeEmpty()
                          .And.HaveCount(10)
                          .And.ContainInOrder("a", "aa", "aaa", "aaaa", "aaaaa",
                                              "aaaaaa", "aaaaaaa", "aaaaaaaa",
                                              "aaaaaaaaa", "aaaaaaaaaa");
        }

        [Fact]
        [Category("Ranges.Range.Iota.WithSimpleGenerator")]
        public void Test_Range_Iota_WithSimpleGenerator_Ints()
        {
            var val = 0;
            var range = Range.Iota(() => val++, (i) => i == 15);

            var list = range.ToList();

            list.Should().NotBeNull()
                          .And.NotBeEmpty()
                          .And.HaveCount(16)
                          .And.ContainInOrder(0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15);
        }

        [Fact]
        [Category("Ranges.Range.Iota.WithSimpleGenerator")]
        public void Test_Range_Iota_WithSimpleGenerator_Strings()
        {
            var val = "a";
            var range = Range.Iota(() => { val += "a"; return val; },
                                   (s) => s?.Length == 10);

            var list = range.ToList();

            list.Should().NotBeNull()
                         .And.NotBeEmpty()
                         .And.HaveCount(9)
                         .And.ContainInOrder("aa", "aaa", "aaaa", "aaaaa",
                                             "aaaaaa", "aaaaaaa", "aaaaaaaa",
                                             "aaaaaaaaa", "aaaaaaaaaa");
        }

        [Fact]
        [Category("Ranges.Range.Iota.WithSimpleGenerator.WithStartValue")]
        public void Test_Range_Iota_WithGenerator_WithStartValue_Ints()
        {
            var range = Range.Iota(5, (i) => i + 1, (i) => i == 15);

            range.Should().NotBeNull()
                          .And.NotBeEmpty()
                          .And.HaveCount(11)
                          .And.ContainInOrder(5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15);
        }

        [Fact]
        [Category("Ranges.Range.Iota.WithGenerator.WithStartValue")]
        public void Test_Range_Iota_WithGenerator_WithStartValue_Strings()
        {
            var range = Range.Iota("hello", (s) => s + "a", (s) => s?.Length == 10);

            range.Should().NotBeNull()
                          .And.NotBeEmpty()
                          .And.HaveCount(6)
                          .And.ContainInOrder("hello", "helloa", "helloaa", "helloaaa",
                                              "helloaaaa", "helloaaaaa");
        }

        [Fact]
        [Category("Ranges.Range.Iota.WithGenerator.WithStartValue")]
        public void Test_Range_Iota_WithGenerator_WithStartValue_StartValueEqualsPredicateCondition()
        {
            var range = Range.Iota(5, (i) => i + 1, (i) => i == 5);

            range.Should().NotBeNull()
                          .And.NotBeEmpty()
                          .And.HaveCount(1)
                          .And.Contain(5);
        }

        [Fact]
        [Category("Ranges.Range.Iota.WithGenerator.WithStartValue")]
        public void Test_Range_Iota_WithGenerator_WithStartValue_VeryNearValueEqualsPredicateCondition()
        {
            var range = Range.Iota(5, (i) => i + 1, (i) => i == 6);

            range.Should().NotBeNull()
                          .And.NotBeEmpty()
                          .And.HaveCount(2)
                          .And.ContainInOrder(5, 6);
        }
    }
}
