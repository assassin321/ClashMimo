using ClashMimo.Application.Rules;

namespace ClashMimo.Infrastructure.Rules;

public sealed class FileRuleBaselineConfigSource(string runtimeDirectory) : IRuleBaselineConfigSource
{
    public string? ReadBaseline(string subscriptionId)
    {
        if (string.IsNullOrWhiteSpace(subscriptionId))
        {
            return null;
        }

        var baselinePath = Path.Combine(runtimeDirectory, subscriptionId, "effective.yaml");
        return File.Exists(baselinePath) ? File.ReadAllText(baselinePath) : null;
    }
}
