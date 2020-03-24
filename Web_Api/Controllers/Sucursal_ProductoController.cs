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
    public class Sucursal_ProductoController : ControllerBase
    {
        private readonly FacturaContext _context;

        public Sucursal_ProductoController(FacturaContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Sucursal_Producto>> Get()
        {
            return _context.Sucursales_Productos.ToList();
        }
    }
}