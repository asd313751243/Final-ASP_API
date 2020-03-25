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

        [HttpGet("{id}")]
        public ActionResult<Sucursal_Producto> GetById(int id)
        {
            var item = _context.Sucursales_Productos.Find(id);

            if (item == null)
            {
                return NotFound();
            }

            return item;
        }

        [HttpPost]
        public ActionResult<Sucursal_Producto> Post(Sucursal_Producto item)
        {
            _context.Sucursales_Productos.Add(item);
            _context.SaveChanges();

            return CreatedAtAction(nameof(GetById), new { id = item.Id }, item);
        }

        [HttpPut("{id}")]
        public ActionResult<Sucursal_Producto> Put(int id, Sucursal_Producto item)
        {
            if (id != item.Id)
            {
                return BadRequest();
            }

            _context.Entry(item).State = EntityState.Modified;
            _context.SaveChanges();

            return Ok();
        }

        [HttpDelete("{id}")]
        public ActionResult<Sucursal_Producto> Delete(int id)
        {
            var item = _context.Sucursales_Productos.Find(id);

            if (item == null)
            {
                return NotFound();
            }

            _context.Sucursales_Productos.Remove(item);
            _context.SaveChanges();

            return Ok();
        }
    }
}