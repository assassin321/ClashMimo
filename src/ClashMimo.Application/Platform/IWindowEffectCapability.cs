using ClashMimo.Application.Settings;

namespace ClashMimo.Application.Platform;

public interface IWindowEffectCapability
{
    IReadOnlyList<WindowEffect> SupportedEffects { get; }
}
