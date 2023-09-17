namespace CoinChanger
{
    public class CoinCombination
    {
        public int QuarterCount { get; }
        public int DimeCount { get; }
        public int NickelCount { get; set; }
        public int CentCount { get; set; }

        public CoinCombination(int quarterCount, int dimeCount, int nickelCount, int centCount)
        {
            QuarterCount = quarterCount;
            DimeCount = dimeCount;
            NickelCount = nickelCount;
            CentCount = centCount;
        }

        public static CoinCombination Create(int quarterCount, int dimeCount, int nickelCount, int centCount)
        {
            return new CoinCombination(quarterCount, dimeCount, nickelCount, centCount);
        }
    }
}
