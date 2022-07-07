using E_Library.Common.Enum.Author;
using E_Library.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace E_Library.BUS.BUS.Authorize
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
    public class AuthorizeAttribute : Attribute, IAuthorizationFilter
    {
        private readonly IList<Permisstions> _permisstions;

        public AuthorizeAttribute(params Permisstions[] permisstions)
        {
            _permisstions = permisstions ?? new Permisstions[] { };
        }

        public void OnAuthorization(AuthorizationFilterContext context)
        {
            // skip authorization if action is decorated with [AllowAnonymous] attribute
            var allowAnonymous = context.ActionDescriptor.EndpointMetadata.OfType<AllowAnonymousAttribute>().Any();
            if (allowAnonymous)
                return;

            // authorization
            var user = (User)context.HttpContext.Items["User"];
            List<Permisstions> permisstions = new List<Permisstions>();
            List<Role> roles = user.UserRoles.Select(s => s.Role).ToList();
            foreach (var role in roles)
            {
                var permisstionRoles = role.PermistionRoles.Select(s => s.Permisstion.PermisstionName).ToList();
                foreach (var permisstion in permisstionRoles)
                {
                    permisstions.Add(permisstion);
                }
            }

            if (user == null || (_permisstions.Any() && !_permisstions.Intersect(permisstions).Any())) 
            {
                //not logged in or role not authorized
                context.Result = new JsonResult(new { message = "Unauthorized" }) { StatusCode = StatusCodes.Status401Unauthorized };
            }
        }
    }
}