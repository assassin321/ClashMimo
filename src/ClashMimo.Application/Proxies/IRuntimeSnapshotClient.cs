
namespace ClashMimo.Application.Proxies;

public interface IRuntimeSnapshotClient
{
    Task<CoreRuntimeSnapshot> GetRuntimeSnapshotAsync(CancellationToken cancellationToken = default);

    Task ResetRuntimeTrafficAsync(CancellationToken cancellationToken = default);
}
