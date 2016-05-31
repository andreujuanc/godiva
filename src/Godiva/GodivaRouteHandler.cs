using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Routing;
using Microsoft.AspNetCore.Http;

namespace Godiva
{
    public class GodivaRouteHandler : IRouter
    {
        private string _name;

        public GodivaRouteHandler(string name)
        {
            _name = name;
        }

        VirtualPathData IRouter.GetVirtualPath(VirtualPathContext context)
        {
            throw new NotImplementedException();
        }

        public async Task RouteAsync(RouteContext context)
        {
            var routeValues = string.Join("", context.RouteData.Values);
            var message = String.Format("{0} Values={1} ", _name, routeValues);
            await context.HttpContext.Response.WriteAsync(message);
        }

       
    }
}
