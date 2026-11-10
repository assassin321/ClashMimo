using ClashMimo.Application.Overrides;
using ClashMimo.Domain.Overrides;

namespace ClashMimo.Infrastructure.Overrides;

public sealed class FileLocalOverrideFileReader : ILocalOverrideFileReader
{
    public string ReadAllText(string filePath)
    {
        return File.ReadAllText(filePath);
    }
}
