using BubaDinner.Application.Services.Interfaces;
using BubaDinner.Domain.Common.Errors;
using ErrorOr;

namespace BubaDinner.Application.Services
{
    public class Test : ITest
    {
        public ErrorOr<string> HandleTest(string message)
        {
           if(message == "Error")
                return ErrorsUser.DuplicateEmail;

            return "No Error";
        }
    }
}
