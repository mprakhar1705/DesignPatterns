// SINGLE RESPONSIBILITY PRINCIPLE
// A class should have only one reason to change
// A class should have only one responsibility

/*
using DesignPatterns.src.SOLIDPrinciples.S_SingleResponsibility;

User user = new User();
user.username = "TonyStark";
user.email = "tstark@marvel.com";

UserService userService = new UserService();
userService.Register(user);
*/

// Open-Closed Principle
// A class should be open for extension but closed for modification
// We should be able to extend a class's behavior without modifying it

using DesignPatterns.src.SOLIDPrinciples.O_OpenClose;

Circle circle = new Circle();
circle.Radius = 5;
Console.WriteLine(circle.CalculateArea());

Rectangle rectangle = new Rectangle();
rectangle.Width = 5;
rectangle.Height = 10;
Console.WriteLine(rectangle.CalculateArea());