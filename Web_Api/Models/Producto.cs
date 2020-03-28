using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web_Api.Models
{
    public class Producto
    {
        public int Id { get; set; }
        public string Nombre_Producto { get; set; }
        public string Precio_Producto { get; set; }
        public string Fecha_Venc_Producto { get; set; }
    }
}
