using FactoryChallenge.Model;
using FactoryChallenge.Model.Interface;

namespace FactoryChallenge.Channel;

public sealed class SmsChannel : INotificationChannel
{
    public void Send(NotificationMessage m)
    {
        var sms = new SmsNotification
        {
            PhoneNumber = m.Recipient,
            Message = m.Body
        };
        sms.Send();
    }
}
