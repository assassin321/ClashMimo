using ClashMimo.Domain.Proxies;
namespace ClashMimo.Application.Proxies;

public interface IProxyConfigSource
{
    string ReadRuntimeConfig();
}
