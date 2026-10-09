using ClashMimo.Application.Updates;

namespace ClashMimo.Application.Runtime;

public sealed record BackgroundTaskStatus(
    long Revision,
    long SubscriptionRevision,
    AppUpdateAutoCheckResult? AppUpdate,
    string? DelaySubscriptionId,
    IReadOnlyDictionary<string, int> Delays,
    long ProviderRevision = 0);
