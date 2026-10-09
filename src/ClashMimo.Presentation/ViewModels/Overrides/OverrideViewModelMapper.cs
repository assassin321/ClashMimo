using ClashMimo.Application.Overrides;
using ClashMimo.Domain.Overrides;
using ClashMimo.Application.Localization;

namespace ClashMimo.Presentation.ViewModels;

internal static class OverrideViewModelMapper
{
    public static OverrideItemViewModel ToOverrideItem(OverrideProfile overrideProfile, ILocalizationService? localization = null)
    {
        return new OverrideItemViewModel(
            overrideProfile.Id,
            overrideProfile.Name,
            overrideProfile.SourceLocation,
            overrideProfile.Format,
            overrideProfile.SourceType == OverrideSourceType.Local,
            overrideProfile.UpdateProxyMode,
            isCreatedBlank: string.IsNullOrWhiteSpace(overrideProfile.SourceLocation),
            lastUpdatedAt: overrideProfile.LastUpdatedAt,
            localization: localization);
    }
}
