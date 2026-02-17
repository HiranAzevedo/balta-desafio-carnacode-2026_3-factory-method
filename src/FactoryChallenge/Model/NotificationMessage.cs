using FactoryChallenge.Model.Interface;

namespace FactoryChallenge.Model;

public sealed class NotificationMessage
{
    public NotificationKind Kind { get; init; }
    public string Recipient { get; init; } = "";
    public string Title { get; init; } = "";
    public string Body { get; init; } = "";
    public bool IsHtml { get; init; }
    public int? Badge { get; init; }
    public bool? UseTemplate { get; init; }
}
