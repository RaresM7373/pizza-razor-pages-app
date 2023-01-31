using System.ComponentModel.DataAnnotations;

namespace RazorPiezzeria.Models;

public class PizzaOrder
{
    public int Id { get; set; }

    [Required]
    [StringLength(50, MinimumLength = 2)]

    public string PizzaName { get; set; } = string.Empty;

    [Required] public float BasePrice { get; set; }
}