using la_mia_pizzeria_post.Models;
using Microsoft.AspNetCore.Mvc;

namespace la_mia_pizzeria_post.Controllers;

public class PizzaController : Controller
{
    
    
    private readonly List<Pizza> _pizzas = new()
    {
        new Pizza
        {
            Id = 1, Name = "Margherita", Description = "Pomodoro Mozzarella", Image = "margherita.png", Price = 4.00m
        },
        new Pizza
        {
            Id = 2, Name = "Diavola", Description = "Margherita + Salame", Image = "diavola.png", Price = 7.00m
        },
        new Pizza
        {
            Id = 3, Name = "Provola", Description = "Bianca con Provola", Image = "provola.png", Price = 6.00m
        },
        new Pizza
        {
            Id = 4, Name = "Paperino", Description = "Bianca con Patatine", Image = "paperino.png", Price = 9.00m
        },
        new Pizza
        {
            Id = 5, Name = "Romanina", Description = "Rossa aglio origano", Image = "romanina.png", Price = 6.00m
        }

    };

    public IActionResult Index()
    {
        return View(_pizzas);
    }

    public IActionResult ShowById(int id)
    {
        Pizza? pizza = _pizzas.Find(x => x.Id == id);
        
        if (pizza == null)
        {
            return View("Error");
        }
        
        return View(pizza);
    }
}