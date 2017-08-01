using System.Net;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using AspNetCoreGlobalModelValidation.Infrastructure.Exceptions;
using AspNetCoreGlobalModelValidation.Infrastructure.Common;

namespace AspNetCoreGlobalModelValidation.Infrastructure.Filters
{
    public class HttpGlobalExceptionFilter : IExceptionFilter
    {
        public HttpGlobalExceptionFilter()
        {
        }

        public void OnException(ExceptionContext context)
        {
            var exception = context.Exception;
            var code = HttpStatusCode.InternalServerError;
            var ajaxResponse = new AjaxResponse
            {
                IsSuccess = false
            };

            if (exception is ValidationException)
            {
                code = HttpStatusCode.BadRequest;
                ajaxResponse.Message = "Bad request";
                // We can serialize exception message here instead of throwing Bad request message
            }
            else
            {
                ajaxResponse.Message = "Internal Server Error";
            }

            context.Result = new JsonResult(ajaxResponse);

            context.HttpContext.Response.StatusCode = (int)code;
            context.ExceptionHandled = true;
        }
    }
}
