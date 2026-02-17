namespace FactoryChallenge.Model;

public class PushNotification
{
    public required string DeviceToken { get; set; }
    public required string Title { get; set; }
    public required string Message { get; set; }

    public int Badge { get; set; }

    public void Send()
    {
        Console.WriteLine($"🔔 Enviando Push para dispositivo {DeviceToken}");
        Console.WriteLine($"   Título: {Title}");
        Console.WriteLine($"   Mensagem: {Message}");
    }
}
