namespace DotNetLearningJourney._04_Interfaces;

internal interface IMessageSender
{
    void Send(string recipient, string message);
}

internal class EmailMessageSender : IMessageSender
{
    public void Send(string recipient, string message) =>
        Console.WriteLine($"Email to {recipient}: {message}");
}

internal class NotificationService(IMessageSender messageSender)
{
    public void Notify(string recipient, string message) => messageSender.Send(recipient, message);
}

internal class InterfaceDemo
{
    public void Run()
    {
        IMessageSender sender = new EmailMessageSender();
        var notifications = new NotificationService(sender);
        notifications.Notify("mentor@example.com", "Week 1 and 2 examples are ready to review.");
    }
}
