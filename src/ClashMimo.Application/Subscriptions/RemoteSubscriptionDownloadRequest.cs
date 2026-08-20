using ClashMimo.Domain.Subscriptions;
namespace ClashMimo.Application.Subscriptions;

public sealed record RemoteSubscriptionDownloadRequest(
    string SubscriptionId,
    string SourceLocation,
    string UserAgent,
    SubscriptionUpdateProxyMode ProxyMode,
    string AgeSecretKey = "");
