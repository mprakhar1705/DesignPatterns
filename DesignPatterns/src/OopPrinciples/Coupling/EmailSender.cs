using System;

namespace DesignPatterns.src.OopPrinciples.Coupling;

public class EmailSender : INotificationService
{
    public void SendNotification(string message)
    {
        Console.WriteLine($"Email sent: {message}");
    }
}
