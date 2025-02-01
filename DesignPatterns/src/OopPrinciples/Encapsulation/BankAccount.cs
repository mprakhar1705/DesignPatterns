using System;

namespace DesignPatterns.src.OopPrinciples.Encapsulation;

public class BankAccount
{
    private decimal balance;

    public BankAccount(decimal balance)
    {
        DepositBalance(balance);
    }

    public decimal GetBalance()
    {
        return balance;
    }

    public void DepositBalance(decimal amount)
    {
        if (amount < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(amount), "The amount to deposit must be positive.");
        }
        balance += amount;
    }

    public void WithdrawBalance(decimal amount)
    {
        if (amount < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(amount), "The amount to withdraw must be positive.");
        }
        if (balance < amount)
        {
            throw new InvalidOperationException("Insufficient funds.");
        }
        balance -= amount;
    }

}

