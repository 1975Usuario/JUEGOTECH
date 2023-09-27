using System;
using System.Collections.Generic;

namespace JuegotecH.Models
{
    public partial class Despachador
    {
        public string DesRut { get; set; } = null!;
        public string DesNombre1 { get; set; } = null!;
        public string DesNombre2 { get; set; } = null!;
        public string DesApellido1 { get; set; } = null!;
        public string DesApellido2 { get; set; } = null!;
        public string DesDireccion { get; set; } = null!;
        public int DesFono { get; set; }
        public string DesEmail { get; set; } = null!;
        public string DesCiudad { get; set; } = null!;

        public virtual Bodega? Bodega { get; set; }
    }
}
