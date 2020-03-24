using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web_Api.Models;

namespace Web_Api.Data
{
    public class FacturaContext: DbContext
    {
        public FacturaContext(DbContextOptions<FacturaContext> options): base(options)
        {
        }

        public DbSet<Almacen> Almacenes { get; set; }
        public DbSet<Almacen_Producto> Almacenes_Productos { get; set; }
        public DbSet<Empleado> Empleados { get; set; }
        public DbSet<Empleado_Producto> Empleados_Productos { get; set; }
        public DbSet<Sucursal> Sucursales { get; set; }
        public DbSet<Sucursal_Producto> Sucursales_Productos { get; set; }
        public DbSet<Producto> Productos { get; set; }
    }
}
