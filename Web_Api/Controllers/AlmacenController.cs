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
    public class AlmacenController : ControllerBase
    {
        private readonly FacturaContext _context;

        public AlmacenController(FacturaContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Almacen>> Get()
        {
            return _context.Almacenes.ToList();
        }

        [HttpGet("{id}")]
        public ActionResult<Almacen> GetById(int id)
        {
            var item = _context.Almacenes.Find(id);

            if(item == null)
            {
                return NotFound();
            }

            return item;
        }

        [HttpPost]
        public ActionResult<Almacen> Post(Almacen item)
        {
            _context.Almacenes.Add(item);
            _context.SaveChanges();

            return CreatedAtAction(nameof(GetById), new { id = item.Id }, item);
        }
    }
}