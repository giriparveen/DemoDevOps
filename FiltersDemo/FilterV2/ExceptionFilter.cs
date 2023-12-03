using Microsoft.AspNetCore.Mvc.Filters;
using System;

namespace FiltersDemo.FilterV2
{
    public class ExceptionFilter : Attribute, IExceptionFilter
    {
        public void OnException(ExceptionContext context)
        {
            throw new NotImplementedException();
        }
    }
}
