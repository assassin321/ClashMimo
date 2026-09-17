using System.Text;
using ClashMimo.Application.Diagnostics;
using ClashMimo.Desktop.Services;
using ClashMimo.Infrastructure.Diagnostics;

namespace ClashMimo.Desktop;

internal static class Program
{
    [STAThread]
    public static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        AppLogger.Configure(new CapturedAppLogger(DesktopApplicationLayout.RunningLogFilePath));
        DependencyDirectoryService.Configure();
        AppRuntime.Run(args);
    }
}
