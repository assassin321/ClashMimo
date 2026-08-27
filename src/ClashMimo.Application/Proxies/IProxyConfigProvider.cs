using ClashMimo.Domain.Proxies;
namespace ClashMimo.Application.Proxies;

public interface IProxyConfigProvider
{
    Task<ProxyConfig> LoadAsync(CancellationToken cancellationToken = default);
}
