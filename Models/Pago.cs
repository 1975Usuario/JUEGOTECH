using System;
using System.Collections.Generic;

namespace JuegotecH.Models
{
    public partial class Pago
    {
        public int PagCodigo { get; set; }
        public DateOnly PagFecha { get; set; }
        public int PagMonto { get; set; }
        public int PagTpaCodigo { get; set; }
        public string PagCliRut { get; set; } = null!;
        public string PagCajRut { get; set; } = null!;

        public virtual Cajero PagCajRutNavigation { get; set; } = null!;
        public virtual Cliente PagCliRutNavigation { get; set; } = null!;
        public virtual TipoPago PagTpaCodigoNavigation { get; set; } = null!;
    }
}
