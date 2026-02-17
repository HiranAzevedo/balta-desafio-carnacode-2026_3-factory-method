using FactoryChallenge.MessageComposer;
using FactoryChallenge.Model;
using FactoryChallenge.Model.Interface;

namespace FactoryChallenge.NotificationComposer;

public sealed class EmailComposer : INotificationComposer
{
    public NotificationMessage ComposeOrderConfirmation(string recipient, string orderNumber) =>
        new()
        {
            Kind = NotificationKind.OrderConfirmation,
            Recipient = recipient,
            Title = "Confirmação de Pedido",
            Body = $"Seu pedido {orderNumber} foi confirmado!",
            IsHtml = true
        };

    public NotificationMessage ComposeShippingUpdate(string recipient, string trackingCode) =>
        new()
        {
            Kind = NotificationKind.ShippingUpdate,
            Recipient = recipient,
            Title = "Pedido Enviado",
            Body = $"Seu pedido foi enviado! Código de rastreamento: {trackingCode}",
            IsHtml = true
        };

    public NotificationMessage ComposePaymentReminder(string recipient, decimal amount) =>
        new()
        {
            Kind = NotificationKind.PaymentReminder,
            Recipient = recipient,
            Title = "Lembrete de Pagamento",
            Body = $"Você tem um pagamento pendente de R$ {amount:N2}",
            IsHtml = true
        };
}
