using System;

namespace DesignPatterns.src.SOLIDPrinciples.S_SingleResponsibility;

public class UserService
{
    public void Register(User user){
        // Register the user
        Console.WriteLine("User registered successfully");

        // Send email
        EmailSender emailSender = new EmailSender();
        emailSender.SendEmail(user.email, "Welcome to our platform!");

    }

}
