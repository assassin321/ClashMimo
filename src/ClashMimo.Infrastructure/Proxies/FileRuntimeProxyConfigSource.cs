using ClashMimo.Application.Proxies;
using ClashMimo.Domain.Proxies;
using ClashMimo.Application.Subscriptions;
using ClashMimo.Domain.Subscriptions;

namespace ClashMimo.Infrastructure.Proxies;

public sealed class FileRuntimeProxyConfigSource(string runtimeDirectory, ISubscriptionSelectionStore selectionStore) : IProxyConfigSource
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
