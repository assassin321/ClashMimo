namespace ClashMimo.Application.Platform;

public sealed record UwpLoopbackOperationResult(bool IsSuccess, string Message, UwpLoopbackPackage? Package);
