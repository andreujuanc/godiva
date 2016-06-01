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
        private readonly GodivaOptions _options;

        public GodivaMiddleware(RequestDelegate next)
        {
            _next = next;
            if (_options == null) _options = new GodivaOptions();
        }
        public GodivaMiddleware(RequestDelegate next, GodivaOptions options) : this(next)
        {
            _options = options;
        }

        public async Task Invoke(HttpContext context)
        {
            if (context.Request.Method == "DEBUG")
            {
                await _next.Invoke(context);
            }
            else
            {
                //template parser
                //route parser
                //check both
                //execute

                var route = new RouteParser(context, _options.RouteTemplate);
                var procedure = route.GetProcedure();
                var db = new DataBaseContext(context);
                await db.Execute(procedure);
                //await context.Response.WriteAsync("what?");
                //await _next.Invoke(context);
            }
        }
    }
}
