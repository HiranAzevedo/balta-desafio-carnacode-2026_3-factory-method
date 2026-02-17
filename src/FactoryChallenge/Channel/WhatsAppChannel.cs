using FactoryChallenge.Model;
using FactoryChallenge.Model.Interface;

namespace FactoryChallenge.Channel;

public sealed class WhatsAppChannel : INotificationChannel
{
    public void Send(NotificationMessage m)
    {
        var wpp = new WhatsAppNotification
        {
            PhoneNumber = m.Recipient,
            Message = m.Body,
            UseTemplate = m.UseTemplate ?? false
        };
        wpp.Send();
    }
}
