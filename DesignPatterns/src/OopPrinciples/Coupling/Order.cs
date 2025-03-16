using System;

namespace DesignPatterns.src.OopPrinciples.Coupling;

public class Order
{
    readonly INotificationService _notificationService;

    public Order(INotificationService notificationService)
    {
        this._notificationService = notificationService;
    }
    public void PlaceOrder()
    {
        _notificationService.SendNotification("Order placed successfully");
    }

}
