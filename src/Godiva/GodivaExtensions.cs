using Microsoft.AspNetCore.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Godiva
{
    public static class GodivaExtensions
    {
        public static IApplicationBuilder UseGodiva(this IApplicationBuilder builder, GodivaOptions options = null)
        {
            if(options != null)
                return builder.UseMiddleware<GodivaMiddleware>(options);
            return builder.UseMiddleware<GodivaMiddleware>();
        }
    }
}
