namespace FactoryChallenge.Model.Interface;

public interface INotificationChannel
{
    void Send(NotificationMessage message);
}

public enum ChannelType { Email, Sms, Push, WhatsApp }


public enum NotificationKind { OrderConfirmation, ShippingUpdate, PaymentReminder }
