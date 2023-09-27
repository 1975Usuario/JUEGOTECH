using System;
using System.Collections.Generic;

namespace JuegotecH.Models
{
    public partial class Cajero
    {
        public string CajRut { get; set; } = null!;
        public string CajNombre1 { get; set; } = null!;
        public string CajNombre2 { get; set; } = null!;
        public string CajApellido1 { get; set; } = null!;
        public string CajApellido2 { get; set; } = null!;
        public string CajDireccion { get; set; } = null!;
        public int CajFono { get; set; }
        public string CajEmail { get; set; } = null!;
        public string CajCiudad { get; set; } = null!;

        public virtual Pago? Pago { get; set; }
    }
}
