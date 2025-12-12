using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RodionProject.Models;

namespace RodionProject.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        var promos = new List<Promo>
        {
            new Promo { ImageUrl = "/images/photo1.png", Text = "🎁 2 грузчика бесплатно при заказе от 5 часов", Description = "Описани111111111111111111111111111111111111111111111" +
                "ыфв" +
                "фыве"},
            new Promo { ImageUrl = "/images/photo2.jpg", Text = "🔥 Скидка 10% на первое обращение" , Description = "Описфыфыфыфыфыфыфыфыфыфыфыфыфыфыфыфыфыфыфыфыфыфыфыфыфыфыфыфыфыфыфыфыфы" +
                "фыание" +
                "ывкция по т тмоу"},
            new Promo { ImageUrl = "/images/photo3.png", Text = "🚚 Бесплатная подача при заказе от 5 часов", Description = "Описа" +
                "ы" +
                "1" +
                "ы" +
                "3" +
                "ние" }
        };

        return View(promos);
    }

}