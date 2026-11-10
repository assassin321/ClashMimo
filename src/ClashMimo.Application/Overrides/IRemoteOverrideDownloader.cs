using ClashMimo.Domain.Overrides;
namespace ClashMimo.Application.Overrides;

public interface IRemoteOverrideDownloader
{
    Task<string> DownloadAsync(OverrideProfile overrideProfile, CancellationToken cancellationToken = default);
}
