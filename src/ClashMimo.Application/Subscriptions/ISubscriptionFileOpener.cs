using ClashMimo.Domain.Subscriptions;
namespace ClashMimo.Application.Subscriptions;

public interface ISubscriptionFileOpener
{
    void OpenSubscriptionFile(string subscriptionId);
}
