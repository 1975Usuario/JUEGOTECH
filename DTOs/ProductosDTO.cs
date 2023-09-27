using System.ComponentModel.DataAnnotations;

namespace JuegotecH.DTOs
{
    public class ProductosDTO
    {
        [Required(ErrorMessage = "El nombre es obligatorio.")]
        /*[MinLength(3, ErrorMessage = "El nombre debe tener al menos 3 caracteres.")]
        [MaxLength(50, ErrorMessage = "El nombre debe tener máximo 50 caracteres.")]
        [RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "El nombre solo puede contener letras.")]*/
        public string Nombre { get; set; }

        [Required(ErrorMessage = "La Descripción es obligatoria.")]
        /*[MinLength(3, ErrorMessage = "El nombre debe tener al menos 3 caracteres.")]
        [MaxLength(50, ErrorMessage = "El nombre debe tener máximo 50 caracteres.")]
        [RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "El nombre solo puede contener letras.")]*/
        public string Descripcion { get; set; }

        [Required(ErrorMessage = "El Stock es obligatorio.")]
        /*[MinLength(3, ErrorMessage = "El nombre debe tener al menos 3 caracteres.")]
        [MaxLength(50, ErrorMessage = "El nombre debe tener máximo 50 caracteres.")]*/
        //RegularExpression(@"^[0-9\i]+$", ErrorMessage = "El nombre solo puede contener letras.")]
        public string Stock { get; set; }

        [Required(ErrorMessage = "La Unidad es obligatoria.")]
        /*[MinLength(3, ErrorMessage = "El nombre debe tener al menos 3 caracteres.")]
        [MaxLength(50, ErrorMessage = "El nombre debe tener máximo 50 caracteres.")]
        [RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "El nombre solo puede contener letras.")]*/
        public string Unidad { get; set; }

        [Required(ErrorMessage = "El Precio Unitario es obligatorio.")]
        /*[MinLength(3, ErrorMessage = "El nombre debe tener al menos 3 caracteres.")]
        [MaxLength(50, ErrorMessage = "El nombre debe tener máximo 50 caracteres.")]
        [RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "El nombre solo puede contener letras.")]*/
        public string PrecioUnitario { get; set; }
    }
}
