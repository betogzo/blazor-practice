using System.ComponentModel.DataAnnotations;

namespace BlazorShop.Models;

public class Product
{
    [Key]
    public int Id { get; set; }

    [Required(ErrorMessage = "Product title is required.")]
    [MinLength(3, ErrorMessage = "Product title must have at least 3 characters.")]
    [MaxLength(120, ErrorMessage = "Product title can't be longer than 120 characters.")]
    public string Title { get; set; } = string.Empty;

    public string? Description { get; set; } = string.Empty;

    [Required(ErrorMessage = "Product value is required.")]
    [DataType(DataType.Currency)]
    public decimal Price { get; set; }

    public int CategoryId { get; set; }
    public Category Category { get; set; } = null!;
}