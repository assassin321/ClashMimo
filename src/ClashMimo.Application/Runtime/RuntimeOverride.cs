using ClashMimo.Application.Overrides;
using ClashMimo.Domain.Overrides;

namespace ClashMimo.Application.Runtime;

public sealed record RuntimeOverride(
    string Id,
    string Name,
    OverrideFormat Format,
    string Content);
