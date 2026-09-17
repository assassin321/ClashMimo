using ClashMimo.Domain.Rules;
namespace ClashMimo.Application.Rules;

public interface IRuleConfigSource
{
    string ReadRuntimeConfig();
}
