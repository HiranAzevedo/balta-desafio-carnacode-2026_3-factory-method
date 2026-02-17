using FactoryChallenge.Channel;
using FactoryChallenge.MessageComposer;
using FactoryChallenge.Model.Interface;
using FactoryChallenge.NotificationComposer;

namespace FactoryChallenge.Sender;

public sealed class EmailSender : NotificationSender
{
    protected override INotificationChannel CreateChannel() => new EmailChannel();
    protected override INotificationComposer CreateComposer() => new EmailComposer();
}

public sealed class SmsSender : NotificationSender
{
    protected override INotificationChannel CreateChannel() => new SmsChannel();
    protected override INotificationComposer CreateComposer() => new SmsComposer();
}

public sealed class PushSender : NotificationSender
{
    protected override INotificationChannel CreateChannel() => new PushChannel();
    protected override INotificationComposer CreateComposer() => new PushComposer();
}

public sealed class WhatsAppSender : NotificationSender
{
    protected override INotificationChannel CreateChannel() => new WhatsAppChannel();
    protected override INotificationComposer CreateComposer() => new WhatsAppComposer();
}