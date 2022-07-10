using ErrorOr;

namespace BubaDinner.Application.Services.Interfaces
{
    public interface ITest
    {
       public ErrorOr<string> HandleTest(string message);
    }
}
