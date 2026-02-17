namespace FactoryChallenge.Model;

public class WhatsAppNotification
{
    public required string PhoneNumber { get; set; }
    public required string Message { get; set; }
    public bool UseTemplate { get; set; }

    public void Send()
    {
        Console.WriteLine($"💬 Enviando WhatsApp para {PhoneNumber}");
        Console.WriteLine($"   Mensagem: {Message}");
        Console.WriteLine($"   Template: {UseTemplate}");
    }
}
