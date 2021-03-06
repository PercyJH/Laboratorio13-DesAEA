using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace APITecsup.Models.Response
{
    public class ProductoResponse
    {
        public int ID { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        //Detalle Producto
        public DateTime fechaCreacion { get; set; }
        public DateTime fechaVencimiento { get; set; }
        public bool IsEnable { get; set; }
        public int precioVenta { get; set; }
        public double igv { get; set; }
    }
}