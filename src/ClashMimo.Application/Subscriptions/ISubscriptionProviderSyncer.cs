using ClashMimo.Domain.Subscriptions;
namespace ClashMimo.Application.Subscriptions;

public interface ISubscriptionProviderSyncer
{
    Task SyncAsync(SubscriptionProvider provider, CancellationToken cancellationToken = default);
}
