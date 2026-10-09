using ClashMimo.Domain.Subscriptions;
namespace ClashMimo.Application.Subscriptions;

public interface ISubscriptionSelectionStore
{
    string? GetCurrentSubscriptionId();

    void SetCurrentSubscriptionId(string? subscriptionId);
}
