using ClashMimo.Domain.Rules;

namespace ClashMimo.Application.Rules;

public interface IRuleOverrideStore
{
    RuleOverrideSet Load(string subscriptionId);

    void Save(RuleOverrideSet set);

    void UpsertTemplate(RuleTemplate template);

    void DeleteTemplate(string templateId);

    void Delete(string subscriptionId);
}
