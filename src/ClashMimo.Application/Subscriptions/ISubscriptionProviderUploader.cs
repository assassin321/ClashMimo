using ClashMimo.Domain.Subscriptions;
namespace ClashMimo.Application.Subscriptions;

public interface ISubscriptionProviderUploader
{
    Task<SubscriptionProviderUploadResult> UploadAsync(SubscriptionProvider provider, string sourcePath, CancellationToken cancellationToken = default);
}
