// See https://aka.ms/new-console-template for more information
using SingletonPattern;
while (true)
{ 
    Console.WriteLine("Enter base currency: ");
    var basecurrency = Console.ReadLine();
    Console.WriteLine("Enter target currency: ");
    var targetcurrency = Console.ReadLine();
    Console.WriteLine("Enter amount: ");
    var amount = decimal.Parse(Console.ReadLine());
    //var coverter = new CurrencyConverter();
    var exchangeAmount = CurrencyConverter.Instance.Convert(basecurrency, targetcurrency, amount);
    Console.WriteLine($"{amount} {basecurrency} = {exchangeAmount} {targetcurrency}");
    Console.WriteLine("-------------------");
}