using ClashMimo.Domain.Rules;
namespace ClashMimo.Application.Rules;

public sealed class RuleListLoader(
    IRuleConfigSource source,
    RuleParser parser)
{
    public IReadOnlyList<RuleItem> LoadRules()
    {
        return parser.Parse(source.ReadRuntimeConfig());
    }
}
