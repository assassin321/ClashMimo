using ClashMimo.Domain.Subscriptions;
namespace ClashMimo.Application.Subscriptions;

public interface ILocalSubscriptionFileReader
{
    string ReadAllText(string filePath);
}
