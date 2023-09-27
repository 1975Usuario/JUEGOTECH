using System;
using System.Collections.Generic;

namespace JuegotecH.Models
{
    public partial class Bodega
    {
        public int BodeCodigo { get; set; }
        public string BodeNombre { get; set; } = null!;
        public int BodeProCodigo { get; set; }
        public string BodeBodRut { get; set; } = null!;
        public string BodeDesRut { get; set; } = null!;

        public virtual Bodeguero BodeBodRutNavigation { get; set; } = null!;
        public virtual Despachador BodeDesRutNavigation { get; set; } = null!;
        public virtual Producto BodeProCodigoNavigation { get; set; } = null!;
    }
}
