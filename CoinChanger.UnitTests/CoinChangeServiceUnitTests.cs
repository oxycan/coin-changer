using FluentAssertions;
using NUnit.Framework;

namespace CoinChanger.UnitTests
{
    [TestFixture]
    public class CoinChangeServiceUnitTests
    {
        #region Setup
        private CoinChangeService service;

        [SetUp]
        public void Setup()
        {
            service = new CoinChangeService();
        }

        public static TestCombination[] testCombinations =
        {
            new TestCombination
            {
                Amount = 1,
                ExpectedNumberOfWays = 1,
                Combination = CoinCombination.Create(quarterCount: 0, dimeCount: 0, nickelCount:0, centCount: 1)
            },
            new TestCombination
            {
                Amount = 2,
                ExpectedNumberOfWays = 1,
                Combination = CoinCombination.Create(quarterCount: 0, dimeCount: 0, nickelCount:0, centCount: 2)
            },
            new TestCombination
            {
                Amount = 3,
                ExpectedNumberOfWays = 1,
                Combination = CoinCombination.Create(quarterCount: 0, dimeCount: 0, nickelCount:0, centCount: 3)
            },
            new TestCombination
            {
                Amount = 4,
                ExpectedNumberOfWays = 1,
                Combination = CoinCombination.Create(quarterCount: 0, dimeCount: 0, nickelCount:0, centCount: 4)
            },
            new TestCombination
            {
                Amount = 5,
                ExpectedNumberOfWays = 2,
                Combination = CoinCombination.Create(quarterCount: 0, dimeCount: 0, nickelCount:0, centCount: 5)
            },
            new TestCombination
            {
                Amount = 5,
                ExpectedNumberOfWays = 2,
                Combination = CoinCombination.Create(quarterCount: 0, dimeCount: 0, nickelCount:1, centCount: 0)
            },
            new TestCombination
            {
                Amount = 6,
                ExpectedNumberOfWays = 2,
                Combination = CoinCombination.Create(quarterCount: 0, dimeCount: 0, nickelCount:0, centCount: 6)
            },
            new TestCombination
            {
                Amount = 6,
                ExpectedNumberOfWays = 2,
                Combination = CoinCombination.Create(quarterCount: 0, dimeCount: 0, nickelCount:1, centCount: 1)
            },
            new TestCombination
            {
                Amount = 7,
                ExpectedNumberOfWays = 2,
                Combination = CoinCombination.Create(quarterCount: 0, dimeCount: 0, nickelCount:0, centCount: 7)
            },
            new TestCombination
            {
                Amount = 7,
                ExpectedNumberOfWays = 2,
                Combination = CoinCombination.Create(quarterCount: 0, dimeCount: 0, nickelCount:1, centCount: 2)
            },
            new TestCombination
            {
                Amount = 8,
                ExpectedNumberOfWays = 2,
                Combination = CoinCombination.Create(quarterCount: 0, dimeCount: 0, nickelCount:0, centCount: 8)
            },
            new TestCombination
            {
                Amount = 8,
                ExpectedNumberOfWays = 2,
                Combination = CoinCombination.Create(quarterCount: 0, dimeCount: 0, nickelCount:1, centCount: 3)
            },
            new TestCombination
            {
                Amount = 9,
                ExpectedNumberOfWays = 2,
                Combination = CoinCombination.Create(quarterCount: 0, dimeCount: 0, nickelCount:0, centCount: 9)
            },
            new TestCombination
            {
                Amount = 9,
                ExpectedNumberOfWays = 2,
                Combination = CoinCombination.Create(quarterCount: 0, dimeCount: 0, nickelCount:1, centCount: 4)
            },
            new TestCombination
            {
                Amount = 10,
                ExpectedNumberOfWays = 4,
                Combination = CoinCombination.Create(quarterCount: 0, dimeCount: 1, nickelCount:0, centCount: 0)
            },
            new TestCombination
            {
                Amount = 10,
                ExpectedNumberOfWays = 4,
                Combination = CoinCombination.Create(quarterCount: 0, dimeCount: 0, nickelCount:2, centCount: 0)
            },
            new TestCombination
            {
                Amount = 10,
                ExpectedNumberOfWays = 4,
                Combination = CoinCombination.Create(quarterCount: 0, dimeCount: 0, nickelCount:1, centCount: 5)
            },
            new TestCombination
            {
                Amount = 10,
                ExpectedNumberOfWays = 4,
                Combination = CoinCombination.Create(quarterCount: 0, dimeCount: 0, nickelCount:0, centCount: 10)
            },
            new TestCombination
            {
                Amount = 11,
                ExpectedNumberOfWays = 4,
                Combination = CoinCombination.Create(quarterCount: 0, dimeCount: 1, nickelCount:0, centCount: 1)
            },
            new TestCombination
            {
                Amount = 11,
                ExpectedNumberOfWays = 4,
                Combination = CoinCombination.Create(quarterCount: 0, dimeCount: 0, nickelCount:1, centCount: 6)
            },
            new TestCombination
            {
                Amount = 11,
                ExpectedNumberOfWays = 4,
                Combination = CoinCombination.Create(quarterCount: 0, dimeCount: 0, nickelCount:2, centCount: 1)
            },
            new TestCombination
            {
                Amount = 11,
                ExpectedNumberOfWays = 4,
                Combination = CoinCombination.Create(quarterCount: 0, dimeCount: 0, nickelCount:0, centCount: 11)
            },

            //
            new TestCombination
            {
                Amount = 12,
                ExpectedNumberOfWays = 4,
                Combination = CoinCombination.Create(quarterCount: 0, dimeCount: 1, nickelCount:0, centCount: 2)
            },
            new TestCombination
            {
                Amount = 12,
                ExpectedNumberOfWays = 4,
                Combination = CoinCombination.Create(quarterCount: 0, dimeCount: 0, nickelCount:1, centCount: 7)
            },
            new TestCombination
            {
                Amount = 12,
                ExpectedNumberOfWays = 4,
                Combination = CoinCombination.Create(quarterCount: 0, dimeCount: 0, nickelCount:2, centCount: 2)
            },
            new TestCombination
            {
                Amount = 12,
                ExpectedNumberOfWays = 4,
                Combination = CoinCombination.Create(quarterCount: 0, dimeCount: 0, nickelCount:0, centCount: 12)
            },
            //
            new TestCombination
            {
                Amount = 13,
                ExpectedNumberOfWays = 4,
                Combination = CoinCombination.Create(quarterCount: 0, dimeCount: 1, nickelCount:0, centCount: 3)
            },
            new TestCombination
            {
                Amount = 13,
                ExpectedNumberOfWays = 4,
                Combination = CoinCombination.Create(quarterCount: 0, dimeCount: 0, nickelCount:1, centCount: 8)
            },
            new TestCombination
            {
                Amount = 13,
                ExpectedNumberOfWays = 4,
                Combination = CoinCombination.Create(quarterCount: 0, dimeCount: 0, nickelCount:2, centCount: 3)
            },
            new TestCombination
            {
                Amount = 13,
                ExpectedNumberOfWays = 4,
                Combination = CoinCombination.Create(quarterCount: 0, dimeCount: 0, nickelCount:0, centCount: 13)
            },
            //
            new TestCombination
            {
                Amount = 14,
                ExpectedNumberOfWays = 4,
                Combination = CoinCombination.Create(quarterCount: 0, dimeCount: 1, nickelCount:0, centCount: 4)
            },
            new TestCombination
            {
                Amount = 14,
                ExpectedNumberOfWays = 4,
                Combination = CoinCombination.Create(quarterCount: 0, dimeCount: 0, nickelCount:1, centCount: 9)
            },
            new TestCombination
            {
                Amount = 14,
                ExpectedNumberOfWays = 4,
                Combination = CoinCombination.Create(quarterCount: 0, dimeCount: 0, nickelCount:2, centCount: 4)
            },
            new TestCombination
            {
                Amount = 14,
                ExpectedNumberOfWays = 4,
                Combination = CoinCombination.Create(quarterCount: 0, dimeCount: 0, nickelCount:0, centCount: 14)
            },

            // 15
            new TestCombination
            {
                Amount = 15,
                ExpectedNumberOfWays = 6,
                Combination = CoinCombination.Create(quarterCount: 0, dimeCount: 1, nickelCount:1, centCount: 0)
            },
            new TestCombination
            {
                Amount = 15,
                ExpectedNumberOfWays = 6,
                Combination = CoinCombination.Create(quarterCount: 0, dimeCount: 1, nickelCount:0, centCount: 5)
            },
            new TestCombination
            {
                Amount = 15,
                ExpectedNumberOfWays = 6,
                Combination = CoinCombination.Create(quarterCount: 0, dimeCount: 0, nickelCount:3, centCount: 0)
            },
            new TestCombination
            {
                Amount = 15,
                ExpectedNumberOfWays = 6,
                Combination = CoinCombination.Create(quarterCount: 0, dimeCount: 0, nickelCount:2, centCount: 5)
            },
            new TestCombination
            {
                Amount = 15,
                ExpectedNumberOfWays = 6,
                Combination = CoinCombination.Create(quarterCount: 0, dimeCount: 0, nickelCount:1, centCount: 10)
            },
            new TestCombination
            {
                Amount = 15,
                ExpectedNumberOfWays = 6,
                Combination = CoinCombination.Create(quarterCount: 0, dimeCount: 0, nickelCount:0, centCount: 15)
            },
        };

        #endregion

        [TestCaseSource(nameof(testCombinations))]
        public void TestWithKnownCombinations(TestCombination testCombination)
        {
            // Act
            var result = service.CalculateWaysToMakeChange(testCombination.Amount);

            // Assert
            result.NumberOfWays.Should().Be(testCombination.ExpectedNumberOfWays);
            IsCombinationValid(testCombination, result).Should().BeTrue();
        }

        [Test]
        public void CompareToDpApproachResults()
        {
            // Arrange 
            var dpService = new DpCoinChangeService();

            for (int amount = 1; amount < 1000; amount++)
            {
                // Act
                var serviceResult = service.CalculateWaysToMakeChange(amount);
                int dpResult = dpService.CountWaysToMakeChange(amount);

                // Assert
                serviceResult.NumberOfWays.Should().Be(dpResult);
            }
        }

        [TestCase(0)]
        [TestCase(-1)]
        public void CalculateWaysToMakeChange_AmountIsLessThanOne_ReturnsInvalidAmountResult(int amount)
        {
            // Act
            var serviceResult = service.CalculateWaysToMakeChange(amount);

            // Assert 
            serviceResult.NumberOfWays.Should().Be(0);
        }

        [TestCase(1)]
        [TestCase(2)]
        public void CalculateWaysToMakeChange_AmountIsGreaterThanZero_ReturnsSuccessResult(int amount)
        {
            // Act
            var serviceResult = service.CalculateWaysToMakeChange(amount);

            // Assert 
            serviceResult.NumberOfWays.Should().BeGreaterThan(0);
        }


        bool IsCombinationValid(TestCombination testCombination, ServiceResult serviceResult)
        {
            return serviceResult.Combinations.Exists(x => x.QuarterCount == testCombination.Combination.QuarterCount
            && x.DimeCount == testCombination.Combination.DimeCount
            && x.NickelCount == testCombination.Combination.NickelCount
            && x.CentCount == testCombination.Combination.CentCount
            );
        }
    }
}
