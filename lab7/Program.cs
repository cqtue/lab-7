using System;
using System.Collections.Generic;

List<Action> actions = new List<Action>();

for (int i = 1; i <= 5; i++)
{
    int number = i; // воо тепер нормально працює
    actions.Add(() => Console.WriteLine(number));
}

foreach (var action in actions)
{
    action();
}