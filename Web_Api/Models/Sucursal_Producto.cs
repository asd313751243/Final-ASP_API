using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web_Api.Models
{
    public class Sucursal_Producto
    {
        public int Id { get; set; }
        public int Id_Sucursal { get; set; }
        public int Id_Producto { get; set; }
        public int Cantidad_Sucursal_Producto { get; set; }
        public DateTime Fecha_Sucursal_Producto { get; set; }
    }
}
