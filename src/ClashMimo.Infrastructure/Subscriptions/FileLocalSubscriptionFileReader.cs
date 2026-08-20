using ClashMimo.Application.Subscriptions;
using ClashMimo.Domain.Subscriptions;

namespace ClashMimo.Infrastructure.Subscriptions;

public sealed class FileLocalSubscriptionFileReader : ILocalSubscriptionFileReader
{
    public string ReadAllText(string filePath)
    {
        return File.ReadAllText(filePath);
    }
}
