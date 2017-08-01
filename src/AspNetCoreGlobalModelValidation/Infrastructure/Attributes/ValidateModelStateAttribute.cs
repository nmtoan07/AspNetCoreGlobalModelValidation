using System;
using Microsoft.AspNetCore.Mvc.Filters;
using AspNetCoreGlobalModelValidation.Infrastructure.Exceptions;
using AspNetCoreGlobalModelValidation.Infrastructure.Extensions;

namespace AspNetCoreGlobalModelValidation.Infrastructure.Attributes
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false, Inherited = false)]
    public class ValidateModelStateAttribute : ActionFilterAttribute
    {
        public ValidateModelStateAttribute()
        {
        }

        public override void OnActionExecuting(ActionExecutingContext context)
        {
            if (!context.ModelState.IsValid)
            {
                throw new ValidationException(context.ModelState.GetErrors());
            }
        }
    }
}
