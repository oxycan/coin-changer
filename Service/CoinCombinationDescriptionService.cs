using System.Text;

namespace CoinChanger.Service
{
    public class CoinCombinationDescriptionService
    {
        public static string CreateCoinCombinationDescription(CoinCombination combination)
        {
            StringBuilder descriptionStringBuilder = new StringBuilder();
            if (combination == null)
            {
                return String.Empty;
            }
            string coinName;
            if (combination.QuarterCount > 0)
            {
                coinName = combination.QuarterCount == 1 ? "quarter" : "quarters";
                descriptionStringBuilder.Append($"{combination.QuarterCount} {coinName} ");
            }
            if (combination.DimeCount > 0)
            {
                coinName = combination.DimeCount == 1 ? "dime" : "dimes";
                descriptionStringBuilder.Append($"{combination.DimeCount} {coinName} ");
            }
            if (combination.NickelCount > 0)
            {
                coinName = combination.NickelCount == 1 ? "nickel" : "nickels";
                descriptionStringBuilder.Append($"{combination.NickelCount} {coinName} ");
            }
            if (combination.CentCount > 0)
            {
                coinName = combination.CentCount == 1 ? "pennie" : "pennies";
                descriptionStringBuilder.Append($"{combination.CentCount} {coinName} ");
            }

            return descriptionStringBuilder.ToString();
        }
    }
}
