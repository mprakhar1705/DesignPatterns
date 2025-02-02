using DesignPatterns.src.OopPrinciples.Abstraction;
using DesignPatterns.src.OopPrinciples.Encapsulation;
using DesignPatterns.src.OopPrinciples.Inheritance;

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

/*EmailService emailService = new EmailService();
emailService.SendEmail();
*/

// Inheritance
Car car = new Car();
car.Brand = "Tata";
car.Start();
car.Stop();

car.NumberOfDoors = 4;