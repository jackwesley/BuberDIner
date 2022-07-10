using ErrorOr;

namespace BubaDinner.Domain.Common.Errors
{
    public static class ErrorsUser
    {
        public static Error DuplicateEmail = Error.Conflict(code: "User.DuplicatedEmail",
            description: "Email already in use");
    }
}
