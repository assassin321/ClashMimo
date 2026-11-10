using ClashMimo.Application.Runtime;

namespace ClashMimo.Desktop.Runtime;

internal sealed record CoreRuntimeStatus(CoreSnapshot Snapshot, long CoreGeneration);

internal sealed record CoreOperationResult(bool IsSuccess, string Message, CoreRuntimeStatus Status);
