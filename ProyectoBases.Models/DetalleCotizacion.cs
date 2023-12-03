﻿using System;
using System.Collections.Generic;

namespace ProyectoBases.Models
{
    public partial class DetalleCotizacion
    {
        public int DetalleCotizacionId { get; set; }
        public int CotizacionId { get; set; }
        public string ProductoId { get; set; } = null!;
        public decimal Cantidad { get; set; }
        public decimal PrecioUnitario { get; set; }
        public decimal? Subtotal { get; set; }

        public virtual Cotizacion Cotizacion { get; set; } = null!;
        public virtual Producto Producto { get; set; } = null!;
    }
}
