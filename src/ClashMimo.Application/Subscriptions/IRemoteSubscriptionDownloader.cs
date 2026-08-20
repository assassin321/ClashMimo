using ClashMimo.Domain.Subscriptions;
namespace ClashMimo.Application.Subscriptions;

public interface IRemoteSubscriptionDownloader
{
    Task<RemoteSubscriptionDownloadResult> DownloadAsync(RemoteSubscriptionDownloadRequest request, CancellationToken cancellationToken = default);
}
