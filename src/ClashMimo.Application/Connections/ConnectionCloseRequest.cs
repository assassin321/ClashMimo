using ClashMimo.Domain.Connections;
namespace ClashMimo.Application.Connections;

public sealed record ConnectionCloseRequest(ConnectionCloseMode Mode, string? ConnectionId = null);
