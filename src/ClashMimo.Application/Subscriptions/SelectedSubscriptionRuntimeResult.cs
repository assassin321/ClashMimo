using ClashMimo.Domain.Subscriptions;
using ClashMimo.Application.Runtime;

namespace ClashMimo.Application.Subscriptions;

public sealed record SelectedSubscriptionRuntimeResult(
    Subscription Subscription,
    string RuntimeConfigContent,
    string? OriginalContentPath = null,
    string? RuntimeConfigPath = null);
