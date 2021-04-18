using System.ComponentModel.DataAnnotations;

namespace BlazorNetCore.Data.Entities
{
    public class Customer
    {
        public int Id { get; set; }

        [MaxLength(15, ErrorMessage = "El {0} campo no puede tener mas de {1} carácteres.")]
        [Required(ErrorMessage = "El {0} campo es obligatorio.")]
        public string Customer_id { get; set; }

        [MaxLength(100, ErrorMessage = "El {0} campo no puede tener mas de {1} carácteres.")]
        [Required(ErrorMessage = "El {0} campo es obligatorio.")]
        public string Customer_name { get; set; }

        [MaxLength(100, ErrorMessage = "El {0} campo no puede tener mas de {1} carácteres.")]
        [Required(ErrorMessage = "El {0} campo es obligatorio.")]
        public string Customer_city { get; set; }
    }
}
