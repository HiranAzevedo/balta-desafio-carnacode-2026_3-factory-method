using FactoryChallenge.Model.Interface;
using FactoryChallenge.Sender;

namespace FactoryChallenge;

public class NotificationManager(Dictionary<ChannelType, NotificationSender> senders)
{
    private readonly Dictionary<ChannelType, NotificationSender> _senders = senders ?? throw new ArgumentNullException(nameof(senders));

    private NotificationSender Resolve(ChannelType notificationType)
    {
        if (_senders.TryGetValue(notificationType, out var sender))
            return sender;

        throw new ArgumentException($"Tipo de notificação '{notificationType}' não suportado");
    }

    public void SendOrderConfirmation(string recipient, string orderNumber, ChannelType notificationType) =>
        Resolve(notificationType).SendOrderConfirmation(recipient, orderNumber);

    public void SendShippingUpdate(string recipient, string trackingCode, ChannelType notificationType) =>
       Resolve(notificationType).SendShippingUpdate(recipient, trackingCode);

    public void SendPaymentReminder(string recipient, decimal amount, ChannelType notificationType) =>
        Resolve(notificationType).SendPaymentReminder(recipient, amount);
}
