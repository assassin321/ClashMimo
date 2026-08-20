using ClashMimo.Domain.Proxies;
namespace ClashMimo.Application.Proxies;

public sealed class ProxyConfigLoader(
    IProxyConfigSource source,
    ProxyConfigParser parser)
{
    public ProxyConfig LoadConfig()
    {
        return parser.Parse(source.ReadRuntimeConfig());
    }
}
