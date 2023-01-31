using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPiezzeria.Models;

namespace RazorPiezzeria.Pages;

public class Pizza : PageModel
{
    public List<PizzasModel> fakePizzaDb = new()
    {
        new PizzasModel
        {
            ImageTitle = "Margerita", PizzaName = "Margerita", BasePrice = 4, TomatoSauce = true, Cheese = true,
            FinalPrice = 6
        },

        new PizzasModel
        {
            ImageTitle = "Pepperoni", PizzaName = "Pepperoni", BasePrice = 4, TomatoSauce = true, Cheese = true,
            FinalPrice = 7
        },
        new PizzasModel
        {
            ImageTitle = "Mushroom", PizzaName = "MushRoom", BasePrice = 4, Mushroom = true, Cheese = true,
            FinalPrice = 9
        },
        new PizzasModel
        {
            ImageTitle = "Vegetarian", PizzaName = "Vegetarian", BasePrice = 2, TomatoSauce = true, Cheese = true,
            FinalPrice = 11
        }
    };

    public IActionResult OnGet()
    {
        return Page();
    }
}