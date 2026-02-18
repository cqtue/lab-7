using System;

Func<double, double> discountCalculator = (price) => price * 0.95;
discountCalculator += (price) => price * 0.90;
discountCalculator += (price) => price - 100;

double currentPrice = 1000;

foreach (var method in discountCalculator.GetInvocationList())
{
    var func = (Func<double, double>)method;
    currentPrice = func(currentPrice);
}

Console.WriteLine($"Результат знижок: {currentPrice}");