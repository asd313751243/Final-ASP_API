using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Web_Api.Data;

namespace Web_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Empleado_ProductoController : ControllerBase
    {
        private readonly FacturaContext _context;

        public Empleado_ProductoController(FacturaContext context)
        {
            _context = context;
        }
    }
}