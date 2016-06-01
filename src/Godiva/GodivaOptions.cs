using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Godiva
{
    public class GodivaOptions
    {
        public string ProcedurePrefix { get; set; }
        public RouteTemplate RouteTemplate { get; set; } = new RouteTemplate();

    }
}
