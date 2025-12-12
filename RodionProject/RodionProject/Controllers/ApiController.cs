using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RodionProject.Models;
using RodionProject.Services;

namespace RodionProject.Controllers;

[Route("api/telegram")]
public class ApiController : ControllerBase
{
    public TelegramBotService _telegramService;
    
    public ApiController(TelegramBotService service)
    {
        _telegramService = service;
    }
    
    [HttpPost]
    public async Task<IActionResult> Index(Order order)
    {
        await _telegramService.SendOrderAsync(order);
        return Ok();
    }
}
