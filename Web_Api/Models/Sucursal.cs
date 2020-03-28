using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web_Api.Models
{
    public class Sucursal
    {
        public int Id { get; set; }
        public string Nombre_Sucursal { get; set; }
        public string Ciudad_Sucursal { get; set; }
        public string Telefono_Sucursal { get; set; }
    }
}
