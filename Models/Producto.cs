using System;
using System.Collections.Generic;

namespace JuegotecH.Models
{
    public partial class Producto
    {
        public int ProCodigo { get; set; }
        public string ProNombre { get; set; } = null!;
        public string ProDescripcion { get; set; } = null!;
        public int ProStock { get; set; }
        public int ProUnidad { get; set; }
        public int ProPrecioUnitario { get; set; }

        public virtual Bodega? Bodega { get; set; }
        public virtual DetalleFactura? DetalleFactura { get; set; }
    }
}
