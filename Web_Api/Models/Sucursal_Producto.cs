using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web_Api.Models
{
    public class Sucursal_Producto
    {
        public int Id { get; set; }
        public string Id_Sucursal { get; set; }
        public string Id_Producto { get; set; }
        public string Cantidad_Sucursal_Producto { get; set; }
        public string Fecha_Sucursal_Producto { get; set; }
    }
}
