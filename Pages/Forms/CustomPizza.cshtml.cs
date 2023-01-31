using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPiezzeria.Models;

namespace RazorPiezzeria.Pages.Forms;

public class CustomPizza : PageModel
{
    [BindProperty] public PizzasModel Pizza { get; set; }
    public float PizzaPrice { get; set; }

    public void OnGet()
    {
    }

    public IActionResult OnPost()
    {
        PizzaPrice = Pizza.BasePrice;
        if (Pizza.TomatoSauce) PizzaPrice += 1;
        if (Pizza.Cheese) PizzaPrice += 2;
        if (Pizza.Pineapple) PizzaPrice += 4;

        return RedirectToPage("/Checkout/Checkout", new { Pizza.PizzaName, PizzaPrice });
    }
}