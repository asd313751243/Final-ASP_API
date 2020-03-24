using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web_Api.Models
{
    public class Empleado_Producto
    {
        public int Id { get; set; }
        public int Id_Empleado { get; set; }
        public int Id_Producto { get; set; }
        public DateTime Fecha_Empleado_Producto { get; set; }
    }
}
