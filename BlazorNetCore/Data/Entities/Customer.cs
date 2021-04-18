using System.ComponentModel.DataAnnotations;

namespace BlazorNetCore.Data.Entities
{
    public class Customer
    {
        public int Id { get; set; }

        [MaxLength(15, ErrorMessage = "El campo {0} no puede tener mas de {1} carácteres.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string Customer_id { get; set; }

        [MaxLength(100, ErrorMessage = "El campo {0} no puede tener mas de {1} carácteres.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string Customer_name { get; set; }

        [MaxLength(100, ErrorMessage = "El campo {0} no puede tener mas de {1} carácteres.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string Customer_city { get; set; }
    }
}
