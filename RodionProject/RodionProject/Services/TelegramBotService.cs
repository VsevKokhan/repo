using System.Threading.Tasks;
using RodionProject.Models;
using Telegram.Bot;
using Telegram.Bot.Types.Enums;

namespace RodionProject.Services;

public class TelegramBotService
{
    private readonly TelegramBotClient _botClient;
    private readonly long _chatId;
    private readonly string _botToken;


    public TelegramBotService()
    {
        _botToken = "8264006883:AAEjLHXGIGiPGG-qY3fZu2_dO_wA3kaMAsA";
        _botClient = new TelegramBotClient(_botToken);
        _chatId = 504969502;
    }

    public async Task SendOrderAsync(Order order)
    {
        string type = order.IsDelivery ? "Доставка" : "Перевозка";
        string message = $"📦 Новый заказ: {type}\n" +
                         (order.IsDelivery ? "" : $"Откуда: {order.Departure}\n") +
                         $"Куда: {order.Destination}\n" +
                         $"Грузчики: {order.NumberOfWorkers}\n" +
                         $"Часы работы: {order.Hours}";


        var s = await _botClient.SendTextMessageAsync(
            chatId: _chatId,
            text: message,
            parseMode: ParseMode.Markdown
        );
        
    }
}