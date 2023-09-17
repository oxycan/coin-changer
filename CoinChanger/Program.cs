using CoinChanger;
using CoinChanger.Service;

var coinChangeService = new CoinChangeService();

while (true)
{
    Console.WriteLine("Please enter an amount in cents to calculate the number of ways to make change. ");
    string line = Console.ReadLine();
    if (!int.TryParse(line, out int amount))
    {
        Console.WriteLine("Please enter a valid number.");

        continue;
    }

    var calculationResult = coinChangeService.CalculateWaysToMakeChange(amount);
    CreateResultMessage(amount, calculationResult);
}

static void CreateResultMessage(int amount, ServiceResult calculationResult)
{
    WriteCombinations(amount, calculationResult);
    Console.WriteLine("");

    Console.WriteLine($"There are {calculationResult.NumberOfWays} ways to make a change for {amount} cents. ");
    Console.WriteLine("");
}

static void WriteCombinations(int amount, ServiceResult calculationResult)
{
    Console.WriteLine("");
    Console.WriteLine($"Change combinations for {amount} cents: ");
    Console.WriteLine("");
    foreach (var combination in calculationResult.Combinations)
    {
        Console.WriteLine(CoinCombinationDescriptionService.CreateCoinCombinationDescription(combination));
    }
}
