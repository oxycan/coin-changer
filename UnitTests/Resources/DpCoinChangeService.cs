namespace CoinChanger.UnitTests
{
    public class DpCoinChangeService
    {
        public int CountWaysToMakeChange(int amount)
        {
            int[] coins = { 25, 10, 5, 1 };
            int[] dp = new int[amount + 1];

            dp[0] = 1;

            foreach (int coin in coins)
            {
                for (int i = coin; i <= amount; i++)
                {
                    dp[i] += dp[i - coin];
                }
            }

            return dp[amount];
        }
    }
}