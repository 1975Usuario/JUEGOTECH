using System;
using System.Collections.Generic;

namespace JuegotecH.Models
{
    public partial class Vendedor
    {
        public string VenRut { get; set; } = null!;
        public string VenNombre1 { get; set; } = null!;
        public string VenNombre2 { get; set; } = null!;
        public string VenApellido1 { get; set; } = null!;
        public string VenApellido2 { get; set; } = null!;
        public string VenDireccion { get; set; } = null!;
        public int VenFono { get; set; }
        public string VenEmail { get; set; } = null!;
        public string VenCiudad { get; set; } = null!;

        public virtual Factura? Factura { get; set; }
    }
}
