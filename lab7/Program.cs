using System;

public class BankTerminal
{
    public Action<int> OnMoneyWithdraw;

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

        terminal.OnMoneyWithdraw = null;

        terminal.OnMoneyWithdraw?.Invoke(999999); 

        terminal.Withdraw(100);
    }
}
// нічо не відбувається