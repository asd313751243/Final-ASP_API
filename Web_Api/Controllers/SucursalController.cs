using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Web_Api.Data;
using Web_Api.Models;

namespace Web_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SucursalController : ControllerBase
    {
        private readonly FacturaContext _context;

        public SucursalController(FacturaContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Sucursal>> Get()
        {
            return _context.Sucursales.ToList();
        }
    }
}