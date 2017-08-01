using System;
using System.Collections.Generic;

namespace AspNetCoreGlobalModelValidation.Infrastructure.Exceptions
{
    public class ValidationException : Exception
    {
        public List<string> Errors { get; set; }

        public ValidationException()
        {
            Errors = new List<string>();
        }

        public ValidationException(List<string> errorDictionary)
        {
            this.Errors = errorDictionary;
        }
    }
}
