namespace ClashMimo.Application.Proxies;

public interface IProxyRuntimeSnapshotSource
{
    ProxyRuntimeSnapshot? LastSnapshot { get; }
}
