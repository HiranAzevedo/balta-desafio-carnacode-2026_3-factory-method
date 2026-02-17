using FactoryChallenge.MessageComposer;
using FactoryChallenge.Model.Interface;

namespace FactoryChallenge.Sender;

public abstract class NotificationSender
{
    protected abstract INotificationChannel CreateChannel();
    protected abstract INotificationComposer CreateComposer();

    public void SendOrderConfirmation(string recipient, string orderNumber)
    {
        var composer = CreateComposer();
        var message = composer.ComposeOrderConfirmation(recipient, orderNumber);
        CreateChannel().Send(message);
    }

    public void SendShippingUpdate(string recipient, string trackingCode)
    {
        var composer = CreateComposer();
        var message = composer.ComposeShippingUpdate(recipient, trackingCode);
        CreateChannel().Send(message);
    }

    public void SendPaymentReminder(string recipient, decimal amount)
    {
        var composer = CreateComposer();
        var message = composer.ComposePaymentReminder(recipient, amount);
        CreateChannel().Send(message);
    }
}