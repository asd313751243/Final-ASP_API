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
    public class EmpleadoController : ControllerBase
    {
        private readonly FacturaContext _context;

        public EmpleadoController(FacturaContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Empleado>> Get()
        {
            return _context.Empleados.ToList();
        }

        [HttpGet("{id}")]
        public ActionResult<Empleado> GetById(int id)
        {
            var item = _context.Empleados.Find(id);

            if (item == null)
            {
                return NotFound();
            }

            return item;
        }

        [HttpPost]
        public ActionResult<Empleado> Post(Empleado item)
        {
            _context.Empleados.Add(item);
            _context.SaveChanges();

            return CreatedAtAction(nameof(GetById), new { id = item.Id }, item);
        }

        [HttpPut("{id}")]
        public ActionResult<Empleado> Put(int id, Empleado item)
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
        public ActionResult<Empleado> Delete(int id)
        {
            var item = _context.Empleados.Find(id);

            if (item == null)
            {
                return NotFound();
            }

            _context.Empleados.Remove(item);
            _context.SaveChanges();

            return Ok();
        }
    }
}