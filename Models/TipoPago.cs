using System;
using System.Collections.Generic;

namespace JuegotecH.Models
{
    public partial class TipoPago
    {
        public int TpaCodigo { get; set; }
        public string TpaNombrePago { get; set; } = null!;

        public virtual Pago? Pago { get; set; }
    }
}
