using System;
using System.Collections.Generic;

namespace JuegotecH.Models
{
    public partial class DetalleFactura
    {
        public int DfaCodigo { get; set; }
        public int DfaFacCodigo { get; set; }
        public int DfaProCodigo { get; set; }
        public int DfaCantidad { get; set; }

        public virtual Factura DfaFacCodigoNavigation { get; set; } = null!;
        public virtual Producto DfaProCodigoNavigation { get; set; } = null!;
    }
}
