using FactoryChallenge.Model;
using FactoryChallenge.Model.Interface;

namespace FactoryChallenge.Channel;

public sealed class EmailChannel : INotificationChannel
{
    public void Send(NotificationMessage msg)
    {
        var email = new EmailNotification
        {
            Recipient = msg.Recipient,
            Subject = msg.Title,
            Body = msg.Body,
            IsHtml = msg.IsHtml
        };
        email.Send();
    }
}
