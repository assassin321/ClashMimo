using ClashMimo.Application.Diagnostics;
using ClashMimo.Application.Platform;

namespace ClashMimo.Desktop.Services;

internal sealed class SingleInstanceService : IDisposable
{
    private readonly Mutex _mutex;

    public SingleInstanceService()
    {
        _mutex = new Mutex(true, SingleInstanceName, out var ownsInstance);
        OwnsInstance = ownsInstance;

        if (!OwnsInstance)
        {
            AppLogger.Warning("App is already running; second instance was blocked");
        }
    }

    public bool OwnsInstance { get; }

    private static string SingleInstanceName => OperatingSystem.IsWindows()
        ? $"Global\\{AppMetadata.Name}.{AppRuntimeNames.ChannelName}.SingleInstance"
        : $"{AppMetadata.Name}.{AppRuntimeNames.ChannelName}.SingleInstance";

    public void Dispose()
    {
        if (OwnsInstance)
        {
            _mutex.ReleaseMutex();
        }

        _mutex.Dispose();
    }
}
