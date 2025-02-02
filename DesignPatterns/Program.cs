using DesignPatterns.src.OopPrinciples.Abstraction;
using DesignPatterns.src.OopPrinciples.Encapsulation;

// Encapsulation
/*
BankAccount account = new BankAccount(100);
Console.WriteLine(account.GetBalance());

account.DepositBalance(50);
Console.WriteLine(account.GetBalance());

account.WithdrawBalance(25);
Console.WriteLine(account.GetBalance());
*/

// Abstraction
EmailService emailService = new EmailService();
emailService.SendEmail();
