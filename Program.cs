using CoinChanger;

int oneDollarInCents = 100;
int amount = 15;

var coinChangeService = new CoinChangeService();
var calculationResult = coinChangeService.CalculateWaysToMakeChange(amount);

Console.WriteLine($"There are {calculationResult.NumberOfWays} ways to make a change for {amount} Cents. ");
Console.Read();


