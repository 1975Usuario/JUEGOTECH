using System;
using System.Collections.Generic;

namespace JuegotecH.Models
{
    public partial class Bodeguero
    {
        public string BodRut { get; set; } = null!;
        public string BodNombre1 { get; set; } = null!;
        public string BodNombre2 { get; set; } = null!;
        public string BodApellido1 { get; set; } = null!;
        public string BodApellido2 { get; set; } = null!;
        public string BodDireccion { get; set; } = null!;
        public int BodFono { get; set; }
        public string BodEmail { get; set; } = null!;
        public string BodCiudad { get; set; } = null!;

        public virtual Bodega? Bodega { get; set; }
    }
}
