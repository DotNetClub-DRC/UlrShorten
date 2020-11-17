using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Primitives;
using UlrShorten.Domain.Interfaces;

namespace UrlShorten.Web.Middleware
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class ShortUrlRedirect
    {
        private readonly RequestDelegate _next;

        public ShortUrlRedirect(RequestDelegate next)
        {
            _next = next;
        }

        public Task Invoke(HttpContext httpContext, IUserAgentService userAgentService)
        {
            httpContext.Request.Headers.TryGetValue("User-Agent", out var uaHeader);
            var parsedUserAgent = userAgentService.ParserUserAgent(uaHeader);

            if (httpContext.Request.Path.ToString() != "/")
            {
                httpContext.Response.Redirect("https://github.com/SudiDav");
            }

            return _next(httpContext);
        }
    }

    // Extension method used to add the middleware to the HTTP request pipeline.
    public static class ShortUrlRedirectExtensions
    {
        public static IApplicationBuilder UseShortUrlRedirect(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<ShortUrlRedirect>();
        }
    }
}