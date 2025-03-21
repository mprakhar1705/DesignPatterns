﻿// SINGLE RESPONSIBILITY PRINCIPLE
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

/*
using DesignPatterns.src.SOLIDPrinciples.O_OpenClose;

Circle circle = new Circle();
circle.Radius = 5;
Console.WriteLine(circle.CalculateArea());

Rectangle rectangle = new Rectangle();
rectangle.Width = 5;
rectangle.Height = 10;
Console.WriteLine(rectangle.CalculateArea());
*/

// Liskov Substitution Principle
// Objects in a program should be replaceable with instances of their subtypes without altering the correctness of the program
// Derived classes must be substitutable for their base classes

/*
using DesignPatterns.src.SOLIDPrinciples.L_LiskovSubstitution;
Shape rectangle = new Rectangle{Width = 5, Height = 10};
//Rectangle rectangle = new Rectangle{Width = 5, Height = 10};
Console.WriteLine(rectangle.Area);

Shape square = new Square{Side = 5};
//Square square = new Square{Side = 5};

Console.WriteLine(square.Area);
*/

// Interface Segregation Principle
// A client should never be forced to implement an interface that it doesn't use

/*
using DesignPatterns.src.SOLIDPrinciples.I_InterfaceSegregation;

var circle = new Circle();  
circle.Radius = 5;
Console.WriteLine(circle.Area());

var sphere = new Sphere();
sphere.Radius = 5;
Console.WriteLine(sphere.Area());
Console.WriteLine(sphere.Volume());
*/

// Dependency Inversion Principle
// High-level modules should not depend on low-level modules. Both should depend on abstractions

using DesignPatterns.src.SOLIDPrinciples.D_DependencyInversion;

Car car = new Car(new Engine());
car.StartCar();

Car electricCar = new Car(new ElectricEngine());
electricCar.StartCar();