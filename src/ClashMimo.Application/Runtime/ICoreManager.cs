using ClashMimo.Application.CoreLogs;
using ClashMimo.Domain.CoreLogs;

namespace ClashMimo.Application.Runtime;

public interface ICoreManager
{
    event EventHandler<CoreSnapshot>? StateChanged;

    event EventHandler<CoreLogMessage>? CoreLogReceived;

    Task<CoreSnapshot> GetSnapshotAsync(CancellationToken cancellationToken = default);

    Task<CoreApplyConfigResult> ApplyConfigAsync(CoreApplyConfigRequest request, CancellationToken cancellationToken = default);

    Task RestartAsync(CancellationToken cancellationToken = default);
}
