using ClashMimo.Domain.Subscriptions;
namespace ClashMimo.Application.Subscriptions;

public interface ISelectedSubscriptionRuntimeStore
{
    SelectedSubscriptionRuntimePaths Save(Subscription subscription, string originalContent, string runtimeConfigContent);

    string SaveEmpty(string runtimeConfigContent);

    string ReadRuntimeConfig(string subscriptionId);

    void Delete(string subscriptionId);
}
