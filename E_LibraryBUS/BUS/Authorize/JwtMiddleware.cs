using E_Library.BUS.IBUS;
using E_Library.Common.Helper;
using E_Library.Repository.IRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Options;

namespace E_Library.BUS.BUS.Authorize
{
    public class JwtMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly AppSettings _appSettings;

        public JwtMiddleware(RequestDelegate next, IOptions<AppSettings> appSettings)
        {
            _next = next;
            _appSettings = appSettings.Value;
        }

        public async Task Invoke(HttpContext context, IAuthenRepository authenRepository, IJwtUtils jwtUtils)
        {
            var token = context.Request.Headers["Authorization"].FirstOrDefault()?.Split(" ").Last();
            var userId = jwtUtils.ValidateJwtToken(token);
            if (userId != null)
            {
                // attach user to context on successful jwt validation
                context.Items["User"] = authenRepository.GetUserById(userId.Value);
            }

            await _next(context);
        }
    }
}