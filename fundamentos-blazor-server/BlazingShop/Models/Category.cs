using System.ComponentModel.DataAnnotations;

namespace BlazingShop.Models
{
    public class Category
    {
        [Key]
        [Required(ErrorMessage = "O ID da Categoria é obrigatório.")]
        public int Id { get; set; }

        [Required(ErrorMessage = "O título da Categoria é obrigatório.")]
        [MinLength(5, ErrorMessage = "O título da Categoria deve conter no mínimo 5 caracteres.")]
        [MaxLength(50, ErrorMessage = "O título da Categoria deve conter no máximo 50 caracteres.")]
        public string Title { get; set; } = string.Empty;

        public List<Product> Products { get; set; } = new();
    }
}
