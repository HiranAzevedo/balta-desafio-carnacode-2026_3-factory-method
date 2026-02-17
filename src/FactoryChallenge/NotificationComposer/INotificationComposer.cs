using FactoryChallenge.Model;

namespace FactoryChallenge.MessageComposer;

public interface INotificationComposer
{
    NotificationMessage ComposeOrderConfirmation(string recipient, string orderNumber);
    NotificationMessage ComposeShippingUpdate(string recipient, string trackingCode);
    NotificationMessage ComposePaymentReminder(string recipient, decimal amount);
}
