namespace ClashMimo.Application.Platform;

public interface INetworkConnectionProbe
{
    NetworkConnectionInfo Detect();
}
