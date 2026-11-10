using ClashMimo.Domain.Rules;

namespace ClashMimo.Presentation.ViewModels;

public sealed class RuleTemplateOptionViewModel(RuleTemplate template) : ViewModelBase
{
    public RuleTemplate Template { get; } = template;
    public string Id => Template.Id;
    public string Name => Template.Name;
    public int RuleCount => Template.Rules.Count;
}
