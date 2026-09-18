using ClashMimo.Domain.Proxies;
using ClashMimo.Application.Connections;
using ClashMimo.Domain.Connections;

namespace ClashMimo.Application.Proxies;

public interface IProxyCoreClient
{
    // null 表示读取失败，空列表表示确无连接
    Task<IReadOnlyList<ConnectionInfo>?> GetConnectionsAsync(CancellationToken cancellationToken = default);

    Task<bool> ChangeProxyAsync(ProxyChangeRequest request, CancellationToken cancellationToken = default);

    Task<bool> ClearProxySelectionAsync(string groupName, CancellationToken cancellationToken = default);

    Task<bool> CloseConnectionsAsync(ConnectionCloseRequest request, CancellationToken cancellationToken = default);

    Task<ProxyRuntimeSnapshot> GetProxiesAsync(CancellationToken cancellationToken = default);

    Task<OutboundMode?> GetOutboundModeAsync(CancellationToken cancellationToken = default);

    Task<bool> SetOutboundModeAsync(OutboundMode mode, CancellationToken cancellationToken = default);

    Task<string?> GetVersionAsync(CancellationToken cancellationToken = default);

    Task<CoreRuntimeStats?> GetRuntimeStatsAsync(CancellationToken cancellationToken = default);

    Task<CoreTrafficRate?> GetTrafficAsync(CancellationToken cancellationToken = default);
}
