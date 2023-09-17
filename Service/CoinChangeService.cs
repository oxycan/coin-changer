namespace CoinChanger
{
    public class CoinChangeService
    {

        private readonly int quarters = 25;
        private readonly int dimes = 10;
        private readonly int nickels = 5;
        private int quartersRemainder;
        private int dimesRemainder;
        private int nickelsRemainder;
        private List<CoinCombination> coinCombinations;
        private CoinCombination coinCombination;

        public ServiceResult CalculateWaysToMakeChange(int amount)
        {
            if (amount <= 0)
            {
                return ServiceResult.Default();
            }

            coinCombinations = new List<CoinCombination>();
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

                int maxDimesCount = quartersRemainder / dimes;
                for (int d = 0; d <= maxDimesCount; d++)
                {
                    dimesRemainder = quartersRemainder - (dimes * d);
                    if (dimesRemainder == 0)
                    {
                        coinCombination = CoinCombination.Create(q, d, 0, 0);
                        coinCombinations.Add(coinCombination);

                        break;
                    }

                    int maxNickelsCount = dimesRemainder / nickels;
                    for (int n = 0; n <= maxNickelsCount; n++)
                    {
                        nickelsRemainder = dimesRemainder - (nickels * n);
                        if (nickelsRemainder == 0)
                        {
                            coinCombination = CoinCombination.Create(q, d, n, 0);
                            coinCombinations.Add(coinCombination);

                            break;
                        }

                        coinCombination = CoinCombination.Create(q, d, n, nickelsRemainder);
                        coinCombinations.Add(coinCombination);
                    }
                }
            }

            return ServiceResult.Create(coinCombinations);
        }
    }
}
