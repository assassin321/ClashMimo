using ClashMimo.Domain.Subscriptions;
namespace ClashMimo.Application.Subscriptions;

public sealed record LocalSubscriptionFileImportRequest(
    string Name,
    string FilePath,
    int AutoTestDelayIntervalMinutes = 0);
