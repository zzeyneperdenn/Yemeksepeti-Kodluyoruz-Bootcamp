using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CustomMiddleWare.Middlewares;
using Microsoft.AspNetCore.Builder;

namespace CustomMiddleWare.Extensions
{
    public static class HW2MiddlewareExtension
    {
        public static IApplicationBuilder UseHW2Middleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<HW2Middleware>();
        }
    }
}