using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web_Api.Models
{
    public class Almacen_Producto
    {
        public int Id { get; set; }
        public int Id_Almacen { get; set; }
        public int Id_Producto { get; set; }
        public int Cantidad_Almacen_Producto { get; set; }
        public DateTime Fecha_Almacen_Producto { get; set; }
    }
}
