using ClashMimo.Domain.Connections;
namespace ClashMimo.Application.Connections;

public sealed record ConnectionOperationResult(
    ConnectionListState State,
    ConnectionCloseRequest Request,
    IReadOnlyList<string> ClosedConnectionIds,
    bool HasClosedAllConnections);
