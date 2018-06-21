using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TelasRegionalesDelSur.Models
{
    public class ProductosBO
    {
        public int ID { get; set; }
        public string NombreProducto { get; set; }
        public string Descripcion { get; set; }
        public string Precio { get; set; }
        public string imagen { get; set; }
       
    }
}