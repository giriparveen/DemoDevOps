using Microsoft.AspNetCore.Mvc.Filters;
using System;

namespace FiltersDemo.Filters
{
    public class ActionFilters : Attribute, IActionFilter
    {
        public void OnActionExecuted(ActionExecutedContext context)
        {
            // After Action Execution Method
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
           // Before Action Execution Method
        }
    }
}
