using ClashMimo.Domain.Overrides;
namespace ClashMimo.Application.Overrides;

public sealed record OverrideDeleteResult(string DeletedOverrideId, IReadOnlyList<string> AffectedSubscriptionIds);
