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

        [HttpGet("{id}")]
        public ActionResult<Sucursal> GetById(int id)
        {
            var item = _context.Sucursales.Find(id);

            if (item == null)
            {
                return NotFound();
            }

            return item;
        }

        [HttpPost]
        public ActionResult<Sucursal> Post(Sucursal item)
        {
            _context.Sucursales.Add(item);
            _context.SaveChanges();

            return CreatedAtAction(nameof(GetById), new { id = item.Id }, item);
        }

        [HttpPut("{id}")]
        public ActionResult<Sucursal> Put(int id, Sucursal item)
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
        public ActionResult<Sucursal> Delete(int id)
        {
            var item = _context.Sucursales.Find(id);

            if (item == null)
            {
                return NotFound();
            }

            _context.Sucursales.Remove(item);
            _context.SaveChanges();

            return Ok();
        }
    }
}