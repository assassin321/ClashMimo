namespace ClashMimo.Application.Platform;

public sealed record SystemProxyHostDetectionResult(string? HostName, IReadOnlyList<string> NetworkAddresses);
