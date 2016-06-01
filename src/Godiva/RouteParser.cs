using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Routing;
using Microsoft.AspNetCore.Http;

namespace Godiva
{
    public class RouteParser
    {
        private HttpContext context;
        private RouteTemplate template;
        public static readonly char[] Separator = { '/' };
        private string[] RouteSegments;
        private string[] TemplateSegments;
        private string ProcedurePrefix;

        public RouteParser(HttpContext context, RouteTemplate template, string procedurePrefix = null)
        {
            this.context = context;
            this.template = template;
            this.RouteSegments = this.GetSegments();
            this.TemplateSegments = template.GetSegments();
            this.ProcedurePrefix = procedurePrefix;
        }

        internal Procedure GetProcedure()
        {
            var name = "";
            bool adding = false;
            var ti = 0;
            for (var i = 0; i < RouteSegments.Length; i++)
            {
                var segment = RouteSegments[i];
                if (segment != TemplateSegments[ti])
                {
                    adding = true;
                    name += segment;
                    if (i < RouteSegments.Length - 1)
                        name += "_";
                }
                else
                {
                    ti++;
                    if (adding)
                    {
                        break;
                    }
                }
            }

            if (string.IsNullOrWhiteSpace(name)) return null;
            if (!string.IsNullOrWhiteSpace(ProcedurePrefix))
            {
                name = ProcedurePrefix + name;
            }

            return new Procedure(name);
        }

        public string[] GetSegments()
        {
            var segments = context.Request.Path.Value.Split(Separator, StringSplitOptions.RemoveEmptyEntries);

            return segments;
        }
    }
}
