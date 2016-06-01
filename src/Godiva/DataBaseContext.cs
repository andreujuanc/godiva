using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Godiva
{
    public class DataBaseContext
    {
        HttpContext _context;
        public DataBaseContext(HttpContext context)
        {
            _context = context;
        }

        public async Task Execute(Procedure procedure)
        {
            _context.Response.Headers.Add("Content-Type", "application/json");

            if (procedure == null)
            {
                await _context.Response.WriteAsync("{ }");
            }
            await _context.Response.WriteAsync($"executed: {procedure.Name}");
        }
    }
}
