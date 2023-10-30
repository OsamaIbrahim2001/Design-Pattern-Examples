using SingleTone;

while (true)
{
    Console.Write("Enter base currency: ");
    var baseCurreny=Console.ReadLine();
    Console.Write("Enter target currency: ");
    var targetCurrency=Console.ReadLine();
    Console.Write("Enter amount: ");
    var amount=decimal.Parse(Console.ReadLine());
    var exchangeAmount = CurrencyConverter.Instance.Covert(baseCurreny, targetCurrency, amount);
    Console.WriteLine($"{amount} {baseCurreny} = {exchangeAmount} {targetCurrency}");
    Console.WriteLine("=======================");

}