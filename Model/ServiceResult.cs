namespace CoinChanger
{
    public class ServiceResult
    {
        public ServiceResult(List<CoinCombination> combinations)
        {
            Combinations = combinations;
        }
        public ServiceResult()
        {
        }

        public List<CoinCombination> Combinations { get; } = new List<CoinCombination>();
        public int NumberOfWays => Combinations.Count;

        public static ServiceResult Create(List<CoinCombination> combinations = null!)
        {
            return new ServiceResult(combinations);
        }

        public static ServiceResult Default()
        {
            return new ServiceResult();
        }

    }
}
