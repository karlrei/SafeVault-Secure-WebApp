using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

public class RoleAuthorizeAttribute : Attribute, IAuthorizationFilter
{
    private readonly string role;

    public RoleAuthorizeAttribute(string role)
    {
        this.role = role;
    }

    public void OnAuthorization(AuthorizationFilterContext context)
    {
        var userRole = context.HttpContext.Session.GetString("UserRole");

        if (userRole != role)
        {
            context.Result = new ForbidResult();
        }
    }
}