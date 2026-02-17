using FactoryChallenge.Model;
using FactoryChallenge.Model.Interface;

namespace FactoryChallenge.Channel;

public sealed class PushChannel : INotificationChannel
{
    public void Send(NotificationMessage m)
    {
        var push = new PushNotification
        {
            DeviceToken = m.Recipient,
            Title = m.Title,
            Message = m.Body,
            Badge = m.Badge ?? 0
        };
        push.Send();
    }
}
