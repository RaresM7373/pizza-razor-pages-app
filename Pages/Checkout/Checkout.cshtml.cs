using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPiezzeria.Data;
using RazorPiezzeria.Models;

namespace RazorPiezzeria.Pages.Checkout;

[BindProperties(SupportsGet = true)]
public class Checkout : PageModel
{
    private readonly ApplicationDbContext _context;

    public Checkout(ApplicationDbContext context)
    {
        _context = context;
    }

    public string PizzaName { get; set; }
    public float PizzaPrice { get; set; }
    public string ImageTitle { get; set; }

    public void OnGet()
    {
        if (string.IsNullOrWhiteSpace(PizzaName)) PizzaName = "Custom";
        if (string.IsNullOrWhiteSpace(ImageTitle)) ImageTitle = "Create";

        var order = new PizzaOrder { PizzaName = PizzaName, BasePrice = PizzaPrice };

        _context.PizzaOrders.Add(order);
        _context.SaveChanges();
    }
}