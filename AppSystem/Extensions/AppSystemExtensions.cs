using FluentValidation.Results;
using System.Collections.Generic;
using System.Linq;

namespace AppSystem.Extensions
{
    public static class AppSystemExtensions
    {
        public static string Messages(this IList<ValidationFailure> errors)
        {
            return string.Join("\r\n", errors.Select(c => c.ErrorMessage));
        }
    }
}
