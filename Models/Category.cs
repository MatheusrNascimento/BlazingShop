using System.ComponentModel.DataAnnotations;

namespace BlazingShop.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }

        [Required(ErrorMessage = "Título é obrigatorio")]
        [MaxLength(50, ErrorMessage = "Título deve ter no máximo 50 caracteres")]
        [MinLength(5, ErrorMessage = "Título deve ter no mínimo 5 caracteres")]
        public string Title { get; set; }

        public List<Product> Products { get; set; } = new();
    }
}
