using FactoryChallenge.MessageComposer;
using FactoryChallenge.Model;
using FactoryChallenge.Model.Interface;

namespace FactoryChallenge.NotificationComposer;

public sealed class PushComposer : INotificationComposer
{
    public NotificationMessage ComposeOrderConfirmation(string recipient, string orderNumber) =>
        new()
        {
            Kind = NotificationKind.OrderConfirmation,
            Recipient = recipient,
            Title = "Pedido Confirmado",
            Body = $"Pedido {orderNumber} confirmado!",
            Badge = 1
        };

    public NotificationMessage ComposeShippingUpdate(string recipient, string trackingCode) =>
        new()
        {
            Kind = NotificationKind.ShippingUpdate,
            Recipient = recipient,
            Title = "Pedido Enviado",
            Body = $"Rastreamento: {trackingCode}",
            Badge = 1
        };

    public NotificationMessage ComposePaymentReminder(string recipient, decimal amount) =>
        new()
        {
            Kind = NotificationKind.PaymentReminder,
            Recipient = recipient,
            Title = "Pagamento Pendente",
            Body = $"R$ {amount:N2} pendente",
            Badge = 1
        };
}
