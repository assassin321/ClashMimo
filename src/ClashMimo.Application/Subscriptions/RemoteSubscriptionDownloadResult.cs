using ClashMimo.Domain.Subscriptions;
namespace ClashMimo.Application.Subscriptions;

public sealed record RemoteSubscriptionDownloadResult(string Content, SubscriptionTrafficInfo? TrafficInfo = null);
