#if DEBUG
using System.Text.Json;
using ClashMimo.Application.Runtime;

namespace ClashMimo.Desktop.Debug;

internal static class CoreStatusFormatter
{
    public static async Task<string> FormatAsync(ICoreManager coreManager)
    {
        var snapshot = await coreManager.GetSnapshotAsync();
        return JsonSerializer.Serialize(new
        {
            state = snapshot.State.ToString(),
            pid = snapshot.Pid,
            controller = snapshot.ExternalController,
            error = snapshot.LastError
        });
    }
}
#endif
