using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace Godiva
{
    public class Procedure
    { 
        public string Name { get; set; }
        public Procedure(string name)
        {
            Name = name;
        }
    }
}
