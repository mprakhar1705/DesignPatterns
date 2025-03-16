using DesignPatterns.src.OopPrinciples.Abstraction;
using DesignPatterns.src.OopPrinciples.Coupling;
using DesignPatterns.src.OopPrinciples.Encapsulation;
//using DesignPatterns.src.OopPrinciples.Inheritance;
using DesignPatterns.src.OopPrinciples.Polymorphism;

// ENCAPSULATION
/*
BankAccount account = new BankAccount(100);
Console.WriteLine(account.GetBalance());

account.DepositBalance(50);
Console.WriteLine(account.GetBalance());

account.WithdrawBalance(25);
Console.WriteLine(account.GetBalance());
*/

// ABSTRACTION

/*
EmailService emailService = new EmailService();
emailService.SendEmail();
*/

// INHERITANCE

/*
Car car = new Car();
car.Brand = "Tata";
car.Start();
car.Stop();
car.NumberOfDoors = 4;
*/

// POLYMORPHISM

/*
List<Vehicle> vehicles = new List<Vehicle>();
vehicles.Add(new Car{Brand = "Tata", Model = "Curvv.ev", Year = 2025});
vehicles.Add(new Motorcycle{ Brand = "Yamaha", Model = "R1", Year = 2022 });    

foreach (var vehicle in vehicles)
{
    vehicle.Start();
    vehicle.Stop();
}
*/

//Coupling

//Order order = new Order(new EmailSender());
Order order = new Order(new SmsSender());

order.PlaceOrder();