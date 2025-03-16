// SINGLE RESPONSIBILITY PRINCIPLE
// A class should have only one reason to change
// A class should have only one responsibility

using DesignPatterns.src.SOLIDPrinciples.S_SingleResponsibility;

User user = new User();
user.username = "TonyStark";
user.email = "tstark@marvel.com";

UserService userService = new UserService();
userService.Register(user);
