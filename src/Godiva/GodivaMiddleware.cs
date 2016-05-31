using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;


//TODO: Take options to define routes https://github.com/Microsoft-Build-2016/CodeLabs-WebDev/tree/master/Module2-AspNetCore#Exercise3
//TODO: Caching? https://github.com/aspnet/Caching/tree/dev/samples/MemoryCacheConcurencySample


namespace Godiva
{
    /// <summary>
    /// 
    /// </summary>
    public class GodivaMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly IApplicationBuilder _app;

        public GodivaMiddleware(IApplicationBuilder app, RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            
            //template parser
            //route parser
            //check both
            //execute

            await context.Response.WriteAsync("what?");
            //await _next.Invoke(context);
        }
    }
}
