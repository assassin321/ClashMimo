using ClashMimo.Domain.Subscriptions;
namespace ClashMimo.Application.Subscriptions;

public sealed record SubscriptionProviderSyncResult(
    IReadOnlyList<string> SyncedProviderNames,
    IReadOnlyList<string> SkippedProviderNames)
{
    public IReadOnlyList<string> FailedProviderNames { get; init; } = [];
}
