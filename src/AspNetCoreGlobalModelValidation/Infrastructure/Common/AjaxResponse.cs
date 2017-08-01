using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreGlobalModelValidation.Infrastructure.Common
{
    public class AjaxResponse
    {
        public bool IsSuccess { get; set; }

        public string Message { get; set; }

        public object Data { get; set; }

        public bool IsAuthenticationError { get; set; }

        public AjaxResponse()
        {
        }
    }
}
