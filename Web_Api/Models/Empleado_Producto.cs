using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web_Api.Models
{
    public class Empleado_Producto
    {
        public int Id { get; set; }
        public string Id_Empleado { get; set; }
        public string Id_Producto { get; set; }
        public string Cantidad_Empleado_Producto { get; set; }
    }
}
