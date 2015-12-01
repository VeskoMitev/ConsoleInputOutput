namespace ConsoleInputOutput
{
    using System;
    class CurrencyCheck
    {
        static void Main(string[] args)
        {
            decimal pricesOfGame;
            decimal[] exchangeRates = new[] {0.035m, 1.5m, 1.95m, 0.5m, 1};
            decimal cheapestGame =Decimal.MaxValue;
            for (int i = 0; i < 5; i++)
            {
                pricesOfGame = uint.Parse(Console.ReadLine()) * exchangeRates[i];
                if (cheapestGame > pricesOfGame) cheapestGame = pricesOfGame;
            }
            Console.WriteLine("{0:F2}",cheapestGame);
        }
    }
}
