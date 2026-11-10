using ClashMimo.Application.Diagnostics;
using ClashMimo.Application.Platform;

namespace ClashMimo.Infrastructure.Platform;

public sealed class UnsupportedAppBehaviorService : IAppBehaviorService
{
    public void Apply(AppBehaviorApplicationRequest request)
    {
        AppLogger.Info($"App behavior request recorded: autoStart={request.IsAutoStartEnabled}");
    }
}
