using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Godiva
{
    public class RouteTemplate
    {
        public string Template { get; set;  }
        public RouteTemplate()
        {

        }

        internal string[] GetSegments()
        {
            return this.Template.Split(RouteParser.Separator , StringSplitOptions.RemoveEmptyEntries);
        }
    }
}
