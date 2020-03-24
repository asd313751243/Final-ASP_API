using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web_Api.Models
{
    public class Almacen
    {
        public int Id { get; set; }
        public string Nombre_Almacen { get; set; }
        public string Ciudad_Almacen { get; set; }
        public int Telefono_Almacen { get; set; }
    }
}
