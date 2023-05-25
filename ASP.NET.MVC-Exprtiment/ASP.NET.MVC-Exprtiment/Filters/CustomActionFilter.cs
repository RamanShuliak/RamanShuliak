using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace ASP.NET.MVC_Exprtiment.Filters
{
    public class CustomActionFilter : Attribute, IActionFilter
    {
        void IActionFilter.OnActionExecuted(ActionExecutedContext context)
        {
            throw new NotImplementedException();
        }

        void IActionFilter.OnActionExecuting(ActionExecutingContext context)
        {
        }
    }
}
