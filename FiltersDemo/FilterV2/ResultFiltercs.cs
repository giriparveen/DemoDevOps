using Microsoft.AspNetCore.Mvc.Filters;
using System;

namespace FiltersDemo.FilterV2
{
    public class ResultFiltercs : Attribute, IResultFilter
    {
        public void OnResultExecuted(ResultExecutedContext context)
        {
            throw new NotImplementedException();
        }

        public void OnResultExecuting(ResultExecutingContext context)
        {
            throw new NotImplementedException();
        }
    }
}
