using ClashMimo.Domain.Subscriptions;
namespace ClashMimo.Application.Subscriptions;

public sealed record SubscriptionUpdateResult(
    IReadOnlyList<string> UpdatedSubscriptionIds,
    IReadOnlyList<string> SkippedSubscriptionIds);
