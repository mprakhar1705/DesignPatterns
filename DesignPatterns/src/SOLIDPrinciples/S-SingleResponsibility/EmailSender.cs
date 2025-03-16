using System;

namespace DesignPatterns.src.SOLIDPrinciples.S_SingleResponsibility;

public class EmailSender
{
    public void SendEmail(string email, string message)
    {
        // Send email
        Console.WriteLine($"Email sent to {email} with message: {message}");
    }

}
