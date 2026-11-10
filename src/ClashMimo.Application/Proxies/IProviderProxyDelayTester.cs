namespace ClashMimo.Application.Proxies;

public interface IProviderProxyDelayTester : IProxyDelayTester
{
    Task<int> TestProviderDelayAsync(
        string providerName,
        string proxyName,
        CancellationToken cancellationToken = default);
}
