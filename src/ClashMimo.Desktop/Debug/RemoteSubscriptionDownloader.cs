using ClashMimo.Application.Subscriptions;
using ClashMimo.Domain.Subscriptions;
using ClashMimo.Infrastructure.Subscriptions;

namespace ClashMimo.Desktop.Debug;

#if DEBUG
internal sealed class RemoteSubscriptionDownloader(Func<(string Host, int Port)> coreProxyEndpointProvider) : IRemoteSubscriptionDownloader
{
    public static int DelayMilliseconds { get; set; }

    public async Task<RemoteSubscriptionDownloadResult> DownloadAsync(RemoteSubscriptionDownloadRequest request, CancellationToken cancellationToken = default)
    {
        if (DelayMilliseconds > 0)
        {
            await Task.Delay(DelayMilliseconds, cancellationToken);
        }

        return await new HttpRemoteSubscriptionDownloader(coreProxyEndpointProvider).DownloadAsync(request, cancellationToken);
    }
}
#endif
