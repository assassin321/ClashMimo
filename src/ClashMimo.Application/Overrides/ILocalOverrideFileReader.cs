using ClashMimo.Domain.Overrides;
namespace ClashMimo.Application.Overrides;

public interface ILocalOverrideFileReader
{
    string ReadAllText(string filePath);
}
