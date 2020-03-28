using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web_Api.Models
{
    public class Almacen_Producto
    {
        public int Id { get; set; }
        public string Id_Almacen { get; set; }
        public string Id_Producto { get; set; }
        public string Cantidad_Almacen_Producto { get; set; }
        public string Fecha_Almacen_Producto { get; set; }
    }
}
