using ClashMimo.Domain.Proxies;

namespace ClashMimo.Application.Proxies;

public sealed record ProxyFixedSelectionReleaseResult(
    ProxyConfig Config,
    IReadOnlyList<string> ReleasedGroupNames)
{
    public bool HasChanges => ReleasedGroupNames.Count > 0;
}
