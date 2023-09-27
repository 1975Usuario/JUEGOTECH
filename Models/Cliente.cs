using System;
using System.Collections.Generic;

namespace JuegotecH.Models
{
    public partial class Cliente
    {
        public string CliRut { get; set; } = null!;
        public string CliNombre1 { get; set; } = null!;
        public string CliNombre2 { get; set; } = null!;
        public string CliApellido1 { get; set; } = null!;
        public string CliApellido2 { get; set; } = null!;
        public string CliDireccion { get; set; } = null!;
        public int CliFono { get; set; }
        public string CliEmail { get; set; } = null!;
        public string CliCiudad { get; set; } = null!;

        public virtual Factura? Factura { get; set; }
        public virtual Pago? Pago { get; set; }
    }
}
