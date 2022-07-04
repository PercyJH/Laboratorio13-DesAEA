﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOMAIN
{
    public class Producto
    {
        public int ID { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public DateTime fechaCreacion { get; set; }
        public bool IsEnable { get; set; }
        public DateTime fechaVencimiento { get; set; }
        public int precioVenta { get; set; }
        public double igv { get; set; }
    }
}
