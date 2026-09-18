using ClashMimo.Domain.Subscriptions;

namespace ClashMimo.Application.Subscriptions;

public sealed record SelectedSubscriptionRuntimeResult(
    Subscription Subscription,
    string RuntimeConfigContent);
