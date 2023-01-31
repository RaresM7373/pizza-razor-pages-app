using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPiezzeria.Data;
using RazorPiezzeria.Models;

namespace RazorPiezzeria.Pages;

public class Orders : PageModel
{
    private readonly ApplicationDbContext _context;

    public List<PizzaOrder> PizzaOrders = new();

    public Orders(ApplicationDbContext context)
    {
        _context = context;
    }

    public void OnGet()
    {
        PizzaOrders = _context.PizzaOrders.ToList();
    }
}