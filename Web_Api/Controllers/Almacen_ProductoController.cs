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
    public class Almacen_ProductoController : ControllerBase
    {
        private readonly FacturaContext _context;

        public Almacen_ProductoController(FacturaContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Almacen_Producto>> Get()
        {
            return _context.Almacenes_Productos.ToList();
        }
    }
}