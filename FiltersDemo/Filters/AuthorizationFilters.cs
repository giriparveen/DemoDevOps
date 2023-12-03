using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;

namespace FiltersDemo.Filters
{
    public class AuthorizationFilters : Attribute, IAuthorizationFilter
    {
        public string FilterName { get; set; }

        private Dictionary<string, bool> FilterStatus = new Dictionary<string, bool>
        {
            {"Loan", true },
            {"HomeLoan", false },
            {"Home", true }
        };
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            if (!FilterStatus[FilterName])
            {
                context.Result = new RedirectToActionResult("Index", "Home", null);
            }
        }
    }
}
