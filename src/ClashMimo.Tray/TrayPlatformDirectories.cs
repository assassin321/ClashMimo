using ClashMimo.Application.Platform;

namespace ClashMimo.Tray;

internal sealed class TrayPlatformDirectories : IPlatformDirectories
{
    public string AppDataDirectory => TrayApplicationLayout.AppDataDirectory;

    public string DepsDirectory => TrayApplicationLayout.DepsDirectory;

    public string CoreDirectory => TrayApplicationLayout.CoreDirectory;

    public string RuntimeDirectory => TrayApplicationLayout.RuntimeDirectory;

    public string SettingsFilePath => TrayApplicationLayout.SettingsFilePath;
}
