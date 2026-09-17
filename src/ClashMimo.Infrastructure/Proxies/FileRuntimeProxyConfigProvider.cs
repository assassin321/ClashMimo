using ClashMimo.Application.Proxies;
using ClashMimo.Domain.Proxies;

namespace ClashMimo.Infrastructure.Proxies;

public sealed class FileRuntimeProxyConfigProvider(ProxyConfigLoader loader) : IProxyConfigProvider
{
    public Task<ProxyConfig> LoadAsync(CancellationToken cancellationToken = default)
    {
        return Task.Run(loader.LoadConfig, cancellationToken);
    }
}
