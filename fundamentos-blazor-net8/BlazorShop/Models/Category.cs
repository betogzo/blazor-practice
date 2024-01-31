using System.ComponentModel.DataAnnotations;

namespace BlazorShop.Models;

public class Category
{
    [Key]
    public int Id { get; set; }

    [Required(ErrorMessage = "Category title is required.")]
    [MinLength(3, ErrorMessage = "Category title must have at least 3 characters.")]
    [MaxLength(60, ErrorMessage = "Category title can't be longer than 60 characters.")]
    public string Title { get; set; } = string.Empty;
}