using ClashMimo.Domain.Proxies;
namespace ClashMimo.Application.Proxies;

public interface IProxyDelayTester
{
    Task<int> TestDelayAsync(string proxyName, CancellationToken cancellationToken = default);
}
