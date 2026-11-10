using ClashMimo.Domain.Overrides;
namespace ClashMimo.Application.Overrides;

public sealed record OverrideUpdateResult(
    IReadOnlyList<string> UpdatedOverrideIds,
    IReadOnlyList<string> SkippedOverrideIds);
