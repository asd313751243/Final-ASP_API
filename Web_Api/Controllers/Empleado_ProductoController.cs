﻿using System;
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
    public class Empleado_ProductoController : ControllerBase
    {
        private readonly FacturaContext _context;

        public Empleado_ProductoController(FacturaContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Empleado_Producto>> Get()
        {
            return _context.Empleados_Productos.ToList();
        }

        [HttpGet("{id}")]
        public ActionResult<Empleado_Producto> GetById(int id)
        {
            var item = _context.Empleados_Productos.Find(id);

            if (item == null)
            {
                return NotFound();
            }

            return item;
        }

        [HttpPost]
        public ActionResult<Empleado_Producto> Post(Empleado_Producto item)
        {
            _context.Empleados_Productos.Add(item);
            _context.SaveChanges();

            return CreatedAtAction(nameof(GetById), new { id = item.Id }, item);
        }

        [HttpPut("{id}")]
        public ActionResult<Empleado_Producto> Put(int id, Empleado_Producto item)
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
        public ActionResult<Empleado_Producto> Delete(int id)
        {
            var item = _context.Empleados_Productos.Find(id);

            if (item == null)
            {
                return NotFound();
            }

            _context.Empleados_Productos.Remove(item);
            _context.SaveChanges();

            return Ok();
        }
    }
}