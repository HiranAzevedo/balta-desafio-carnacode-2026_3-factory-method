using FactoryChallenge.MessageComposer;
using FactoryChallenge.Model;
using FactoryChallenge.Model.Interface;

namespace FactoryChallenge.NotificationComposer;

public sealed class SmsComposer : INotificationComposer
{
    public NotificationMessage ComposeOrderConfirmation(string recipient, string orderNumber) =>
        new()
        {
            Kind = NotificationKind.OrderConfirmation,
            Recipient = recipient,
            Title = "",
            Body = $"Pedido {orderNumber} confirmado!"
        };

    public NotificationMessage ComposeShippingUpdate(string recipient, string trackingCode) =>
        new()
        {
            Kind = NotificationKind.ShippingUpdate,
            Recipient = recipient,
            Body = $"Pedido enviado! Rastreamento: {trackingCode}"
        };

    public NotificationMessage ComposePaymentReminder(string recipient, decimal amount) =>
        new()
        {
            Kind = NotificationKind.PaymentReminder,
            Recipient = recipient,
            Body = $"Pagamento pendente: R$ {amount:N2}"
        };
}
