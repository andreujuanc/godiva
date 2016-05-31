using Microsoft.AspNetCore.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Godiva
{
    public static class GodivaExtensions
    {
        public static IApplicationBuilder UseGodiva(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<GodivaMiddleware>();
        }
    }
}
