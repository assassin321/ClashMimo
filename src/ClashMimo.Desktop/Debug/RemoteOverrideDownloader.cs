using ClashMimo.Application.Overrides;
using ClashMimo.Domain.Overrides;
using ClashMimo.Infrastructure.Overrides;

namespace ClashMimo.Desktop.Debug;

#if DEBUG
internal sealed class RemoteOverrideDownloader : IRemoteOverrideDownloader
{
    public Task<string> DownloadAsync(OverrideProfile overrideProfile, CancellationToken cancellationToken = default)
    {
        return new HttpRemoteOverrideDownloader().DownloadAsync(overrideProfile, cancellationToken);
    }
}
#endif
