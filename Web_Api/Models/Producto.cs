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
        public double Precio_Producto { get; set; }
        public DateTime Fecha_Venc_Producto { get; set; }
        public int Cantidad { get; set; }
    }
}
