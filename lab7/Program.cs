using System;

public class BankTerminal
{
    public event Action<int> OnMoneyWithdraw;

    public void Withdraw(int amount)
    {
        OnMoneyWithdraw?.Invoke(amount);
    }
}

class Program
{
    static void Main()
    {
        BankTerminal terminal = new BankTerminal();

        terminal.OnMoneyWithdraw += (amount) => Console.WriteLine($"Знято: {amount} грн");

        // terminal.OnMoneyWithdraw = null; // Помилка компіляції!
        
        // terminal.OnMoneyWithdraw.Invoke(500); // Помилка компіляції!

        terminal.Withdraw(100);
    }
}
// воо