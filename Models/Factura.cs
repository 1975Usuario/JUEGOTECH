using System;
using System.Collections.Generic;

namespace JuegotecH.Models
{
    public partial class Factura
    {
        public int FacCodigo { get; set; }
        public DateOnly FacFecha { get; set; }
        public int FacPago { get; set; }
        public string FacCliRut { get; set; } = null!;
        public string FacVenRut { get; set; } = null!;

        public virtual Cliente FacCliRutNavigation { get; set; } = null!;
        public virtual Vendedor FacVenRutNavigation { get; set; } = null!;
        public virtual DetalleFactura? DetalleFactura { get; set; }
    }
}
