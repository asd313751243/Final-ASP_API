using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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

        [HttpGet("{id}")]
        public ActionResult<Almacen_Producto> GetById(int id)
        {
            var item = _context.Almacenes_Productos.Find(id);

            if (item == null)
            {
                return NotFound();
            }

            return item;
        }

        [HttpPost]
        public ActionResult<Almacen_Producto> Post(Almacen_Producto item)
        {
            _context.Almacenes_Productos.Add(item);
            _context.SaveChanges();

            return CreatedAtAction(nameof(GetById), new { id = item.Id }, item);
        }

        [HttpPut("{id}")]
        public ActionResult<Almacen_Producto> Put(int id, Almacen_Producto item)
        {
            if(id != item.Id)
            {
                return BadRequest();
            }

            _context.Entry(item).State = EntityState.Modified;
            _context.SaveChanges();

            return Ok();
        }

        [HttpDelete("{id}")]
        public ActionResult<Almacen_Producto> Delete(int id)
        {
            var item = _context.Almacenes_Productos.Find(id);

            if(item == null)
            {
                return NotFound();
            }

            _context.Almacenes_Productos.Remove(item);
            _context.SaveChanges();

            return Ok();
        }
    }
}