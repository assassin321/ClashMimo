namespace ClashMimo.Application.Runtime;

public interface IConfigOverrideEngine
{
    string Apply(string baseConfigContent, RuntimeOverride runtimeOverride);
}
