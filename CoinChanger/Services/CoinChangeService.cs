namespace CoinChanger
{
    public class CoinChangeService
    {
        #region members & setup
        private readonly int quarters = 25;
        private readonly int dimes = 10;
        private readonly int nickels = 5;
        private int quartersRemainder;
        private int dimesRemainder;
        private int nickelsRemainder;
        private List<CoinCombination> coinCombinations;
        private CoinCombination coinCombination;
        #endregion

        public ServiceResult CalculateWaysToMakeChange(int amount)
        {
            if (amount <= 0)
            {
                return ServiceResult.Default();
            }

            coinCombinations = new List<CoinCombination>();
            CalculateWays(amount);

            return ServiceResult.Create(coinCombinations);
        }

        #region private methods
        private void CalculateWays(int amount)
        {
            int maxQuartersCount = amount / quarters;
            for (int q = 0; q <= maxQuartersCount; q++)
            {
                quartersRemainder = amount - (quarters * q);
                if (quartersRemainder < 0)
                {
                    break;
                }

                if (quartersRemainder == 0)
                {
                    coinCombination = CoinCombination.Create(q, 0, 0, 0);
                    coinCombinations.Add(coinCombination);

                    break;
                }

                CalculateDimes(quartersRemainder, q);
            }
        }

        private void CalculateDimes(int amount, int numberOfQuarters)
        {
            int maxDimesCount = amount / dimes;
            for (int d = 0; d <= maxDimesCount; d++)
            {
                dimesRemainder = amount - (dimes * d);
                if (dimesRemainder == 0)
                {
                    coinCombination = CoinCombination.Create(numberOfQuarters, d, 0, 0);
                    coinCombinations.Add(coinCombination);

                    break;
                }

                CalculateNickels(dimesRemainder, numberOfQuarters, d);
            }
        }

        private void CalculateNickels(int amount, int numberOfQuarters, int numberOfDimes)
        {
            int maxNickelsCount = amount / nickels;
            for (int n = 0; n <= maxNickelsCount; n++)
            {
                nickelsRemainder = amount - (nickels * n);
                if (nickelsRemainder == 0)
                {
                    coinCombination = CoinCombination.Create(numberOfQuarters, numberOfDimes, n, 0);
                    coinCombinations.Add(coinCombination);

                    break;
                }

                coinCombination = CoinCombination.Create(numberOfQuarters, numberOfDimes, n, nickelsRemainder);
                coinCombinations.Add(coinCombination);
            }
        }
        #endregion
    }
}
