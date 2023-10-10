using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ErrorOr;

namespace BuberBreakfast.ServiceErrors
{
    public static class Errors
    {
        public static class Breakfast
        {
            public static Error NotFound => Error.NotFound(
                code: "Breakfast.NotFound",
                description: "Breakfast not found"
            );

            public static Error InvalidName => Error.Validation(
                code: "Breakfast.InvalidName",
                description: $"Breakfast name length must be within the range from {Models.Breakfast.MinNameLength} to {Models.Breakfast.MaxNameLength}."
            );

            public static Error InvalidDescription => Error.Validation(
                code: "Breakfast.InvalidDescription",
                description: $"Breakfast description length must be within the range from {Models.Breakfast.MinDescriptionLength} to {Models.Breakfast.MaxDescriptionLength}."
            );
        }
    }
}