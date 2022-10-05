using la_mia_pizzeria_post.Context;
using la_mia_pizzeria_post.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace la_mia_pizzeria_post.Controllers;

public class PizzaController : Controller
{
    public IActionResult Index()
    {
        List<Pizza> pizzas = new();
        using (PizzaContext db = new PizzaContext())
        {
            pizzas = db.Pizzas.ToList();
        }
        return View(pizzas);
    }

    public IActionResult ShowById(int id)
    {
        Pizza? pizza = new();
        using (var db = new PizzaContext())
        {
            pizza = db.Pizzas.FirstOrDefault(x => x.Id == id);
        }

        return View(pizza);
    }
    
    public IActionResult Create()
    {
        return View();
    }
    
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Create(Pizza pizza)
    {
        if (!ModelState.IsValid)
        {
            return View("Create",pizza);
        }

        using (var db = new PizzaContext())
        {
            db.Pizzas.Add(pizza);
            
            db.SaveChanges();
        }
        return RedirectToAction("Index");
        
    }
}