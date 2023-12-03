using Microsoft.AspNetCore.Mvc.Filters;
using System;

namespace FiltersDemo.FilterV2
{
    public class AthorizedFilter : Attribute, IAuthorizationFilter
    {
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            throw new NotImplementedException();
        }
    }
}
