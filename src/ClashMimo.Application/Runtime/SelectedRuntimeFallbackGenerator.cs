using ClashMimo.Application.Diagnostics;
using ClashMimo.Application.Subscriptions;

namespace ClashMimo.Application.Runtime;

public sealed class SelectedRuntimeFallbackGenerator(
    ISubscriptionStore subscriptionStore,
    SubscriptionOverrideSelectionUpdater overrideSelectionUpdater,
    SelectedSubscriptionRuntimeGenerator runtimeGenerator)
{
    public SelectedRuntimeFallbackResult Generate(string subscriptionId, SelectedSubscriptionRuntimeRequest request)
    {
        try
        {
            return new SelectedRuntimeFallbackResult(runtimeGenerator.Generate(subscriptionId, request), OverridesDisabled: false);
        }
        catch (Exception exception)
        {
            var subscription = subscriptionStore.LoadSubscriptions().FirstOrDefault(item => item.Id == subscriptionId);
            if (subscription is null || subscription.OverrideIds.Count == 0)
            {
                throw;
            }

            overrideSelectionUpdater.DisableOverridesForSubscription(subscriptionId);
            AppLogger.Warning($"Runtime generation failed with subscription overrides; disabled them and retried: {subscriptionId}, {exception.Message}");
            return new SelectedRuntimeFallbackResult(runtimeGenerator.Generate(subscriptionId, request), OverridesDisabled: true);
        }
    }
}

public sealed record SelectedRuntimeFallbackResult(
    SelectedSubscriptionRuntimeResult Runtime,
    bool OverridesDisabled);
