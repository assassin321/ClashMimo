using ClashMimo.Application.Platform;

namespace ClashMimo.Tray;

public static class GlobalHotkeyServiceFactory
{
    public static IGlobalHotkeyService Create(Action<GlobalHotkeyAction> activated)
    {
        return OperatingSystem.IsWindows()
            ? new WindowsGlobalHotkeyService(activated)
            : new UnsupportedGlobalHotkeyService(activated);
    }
}
