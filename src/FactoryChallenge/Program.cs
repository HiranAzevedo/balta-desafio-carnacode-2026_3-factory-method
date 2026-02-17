// See https://aka.ms/new-console-template for more information
using FactoryChallenge;
using FactoryChallenge.Model.Interface;
using FactoryChallenge.Sender;

Console.WriteLine("=== Sistema de Notificações ===\n");

var senders = new Dictionary<ChannelType, NotificationSender>
{
    [ChannelType.Email] = new EmailSender(),
    [ChannelType.Sms] = new SmsSender(),
    [ChannelType.Push] = new PushSender(),
    [ChannelType.WhatsApp] = new WhatsAppSender()
};

// Injetar os senders no manager
var manager = new NotificationManager(senders);

// Cliente 1 prefere Email
manager.SendOrderConfirmation("cliente@email.com", "12345", ChannelType.Email);
Console.WriteLine();

// Cliente 2 prefere SMS
manager.SendOrderConfirmation("+5511999999999", "12346", ChannelType.Sms);
Console.WriteLine();

// Cliente 3 prefere Push
manager.SendShippingUpdate("device-token-abc123", "BR123456789", ChannelType.Push);
Console.WriteLine();

// Cliente 4 prefere WhatsApp
manager.SendPaymentReminder("+5511888888888", 150.00m, ChannelType.WhatsApp);

// Perguntas para reflexão:
// - Como adicionar novos tipos de notificação (Telegram, Slack) sem modificar NotificationManager?
// - Como evitar duplicação da lógica condicional em cada método?
// - Como permitir que subclasses decidam qual tipo de notificação criar?
// - Como tornar o código mais extensível e manutenível?
