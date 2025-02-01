using DesignPatterns.src.OopPrinciples.Encapsulation;

// Encapsulation
BankAccount account = new BankAccount(100);
Console.WriteLine(account.GetBalance());

account.DepositBalance(50);
Console.WriteLine(account.GetBalance());

account.WithdrawBalance(250);
Console.WriteLine(account.GetBalance());
