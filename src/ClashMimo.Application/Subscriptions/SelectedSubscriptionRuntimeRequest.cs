using ClashMimo.Domain.Subscriptions;
using ClashMimo.Application.Runtime;

namespace ClashMimo.Application.Subscriptions;

public sealed record SelectedSubscriptionRuntimeRequest(
    IReadOnlyList<RuntimeOverride> Overrides,
    RuntimeConfigParams RuntimeParams);
