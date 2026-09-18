using ClashMimo.Application.Rules;
using ClashMimo.Domain.Rules;
using ClashMimo.Application.Subscriptions;
using ClashMimo.Domain.Subscriptions;

namespace ClashMimo.Infrastructure.Rules;

public sealed class FileRuntimeRuleConfigSource(string runtimeDirectory, ISubscriptionSelectionStore selectionStore) : IRuleConfigSource
{
    public string ReadRuntimeConfig()
    {
        var subscriptionId = selectionStore.GetCurrentSubscriptionId();
        if (string.IsNullOrWhiteSpace(subscriptionId))
        {
            return "{}";
        }

        var runtimePath = Path.Combine(runtimeDirectory, subscriptionId, "runtime.yaml");
        return File.Exists(runtimePath) ? File.ReadAllText(runtimePath) : "{}";
    }
}
