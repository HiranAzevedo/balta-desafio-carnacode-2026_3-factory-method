namespace FactoryChallenge.Model;

internal class EmailNotification
{
    public string? Recipient { get; set; }
    public string? Subject { get; set; }
    public string? Body { get; set; }
    public bool? IsHtml { get; set; }

    public void Send()
    {
        Console.WriteLine($"📧 Enviando Email para {Recipient}");
        Console.WriteLine($"   Assunto: {Subject}");
        Console.WriteLine($"   Mensagem: {Body}");
    }
}